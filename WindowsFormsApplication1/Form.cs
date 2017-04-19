using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP22;

namespace Graph

{
    delegate void ChooseOperation(Vertex<int> ex);
    public partial class Form: System.Windows.Forms.Form
    {
        Graph<int> graph;
        Drawing<int> draw;
        List<Vertex<int>> vertexes;
        List<Edge<int>> edges;
        int count = 0;
        int firstClick = -1;
        int secondClick = -1;
        int[,] matrix;
        Random rnd = new Random();
         
        public Form()
        {
            InitializeComponent();
            graph = new Graph<int>();
            draw = new Drawing<int>(pictureBox1.Width, pictureBox1.Height);
            vertexes = new List<Vertex<int>>();
            edges = new List<Edge<int>>();
        }

        private void buttonAddVertex_Click(object sender, EventArgs e)
        {
            buttonAddVertex.Enabled = false;
            buttonAddEdge.Enabled = true;
            pictureBox1.Enabled = true;
            textBoxVertex.Enabled = true;
            textBoxEdge.Enabled = false;
        }

        private void buttonAddEdge_Click(object sender, EventArgs e)
        {
            matrix = new int[vertexes.Count, vertexes.Count];
            buttonAddVertex.Enabled = true;
            buttonAddEdge.Enabled = false;
            pictureBox1.Enabled = true;
            textBoxVertex.Enabled = false;
            textBoxEdge.Enabled = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if(buttonAddEdge.Enabled)
            {     
                graph.AddVertex(vertexes, count, Convert.ToInt32(textBoxVertex.Text), e.X, e.Y);
                count++;
                draw.DrawVertex(e.X, e.Y, textBoxVertex.Text, pictureBox1);
            }
            if(buttonAddVertex.Enabled)
            {
                for(int i = 0; i<vertexes.Count; i++)
                    if((Math.Pow((vertexes[i].x-e.X),2)+Math.Pow((vertexes[i].y-e.Y),2) <= draw.radius*draw.radius))
                    {
                        if(firstClick == -1)
                        {
                            firstClick = i;
                            break;
                        }
                        if (secondClick == -1)
                        {
                            secondClick = i;
                            vertexes[firstClick].listOfEdges.Add(vertexes[secondClick]);
                            vertexes[secondClick].listOfEdges.Add(vertexes[firstClick]);
                            matrix[firstClick, secondClick] = Convert.ToInt32(textBoxEdge.Text);
                            matrix[secondClick, firstClick] = Convert.ToInt32(textBoxEdge.Text);
                            graph.AddEdge(edges, vertexes[firstClick], vertexes[secondClick], Convert.ToInt32(textBoxEdge.Text));
                            draw.DrawEdge(vertexes[firstClick], vertexes[secondClick], textBoxEdge.Text, new Pen(Color.Black), pictureBox1);
                            firstClick = -1;
                            secondClick = -1;
                        }
                    }
            }
        }

        private void buttonDfs_Click(object sender, EventArgs e)
        {
            ReInit();
            ChooseOperation op1 = graph.Dfs;
            for(int i=0; i< vertexes.Count; i++)
            {
                if (!vertexes[i].visit)
                {
                    op1(vertexes[i]);
                }
            }
            textBoxDfs.Text = graph.numberOfVertex;
        }

        private void buttonBfs_Click(object sender, EventArgs e)
        {
            ReInit();
            ChooseOperation op2 = graph.Bfs;
            //for(int i=0; i < vertexes.Count; i++)
            //{
            //    if (!vertexes[i].visit)
            //    {
            //        op2(vertexes[i]);
            //    }
            //}
            op2(vertexes[0]);
            textBoxBfs.Text = graph.numberOfVertex;
        }

        private void buttonKraskala_Click(object sender, EventArgs e)
        {
            ReInit();
            List<Edge<int>> result = graph.Kraskala(vertexes, edges);
            for(int i=0; i<result.Count;i++)
            {
                draw.DrawEdge(result[i].firstVertex, result[i].secondVertex, Convert.ToString(result[i].data), new Pen(Color.Green), pictureBox1);
            }
        }

        private void buttonDijkstra_Click(object sender, EventArgs e)
        {
            ReInit();
            graph.Dijkstra(vertexes, matrix, rnd.Next(1, vertexes.Count - 1));
            for (int i = 0; i < vertexes.Count; i++)
            {
                draw.g.DrawString(Convert.ToString(vertexes[i].sumRoad), new Font("Arial", 10), Brushes.Red, vertexes[i].x + 9, vertexes[i].y + 9);
                pictureBox1.Image = draw.bmp;
            }
        }

        public void ReInit()
        {
            for (int i = 0; i < vertexes.Count; i++)
            {
                vertexes[i].visit = false;
                vertexes[i].sumRoad = int.MaxValue;
            }
            graph.numberOfVertex = "";
        }

    }
}
