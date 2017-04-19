using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using OOP22;

namespace Graph
{
    class Drawing<T> where T : struct
    {
        public Graphics g;
        public Bitmap bmp;
        public int radius = 20;

        public Drawing(int width, int height)
        {
            bmp = new Bitmap(width, height);
            g = Graphics.FromImage(bmp);
        }

        public void DrawVertex(int x, int y, string data, PictureBox pictureBox)
        {
            g.FillEllipse(Brushes.White, (x - radius), (y - radius), 2 * radius, 2 * radius);
            g.DrawEllipse(new Pen(Color.Black), (x - radius), (y - radius), 2 * radius, 2 * radius);
            g.DrawString(data, new Font("Arial", 10), Brushes.Black, (x - 9), (y - 9));
            pictureBox.Image = bmp;
        }

        public void DrawEdge(Vertex<T> firstVertex, Vertex<T> secondVertex, string data, Pen pen, PictureBox pictureBox)
        {
            g.DrawLine(pen, firstVertex.x, firstVertex.y, secondVertex.x, secondVertex.y);
            g.DrawString(data, new Font("Arial", 10), Brushes.Black, (firstVertex.x + secondVertex.x) / 2, (firstVertex.y + secondVertex.y) / 2);
            DrawVertex(firstVertex.x, firstVertex.y, Convert.ToString(firstVertex.data), pictureBox);
            DrawVertex(secondVertex.x, secondVertex.y, Convert.ToString(secondVertex.data), pictureBox);
        }

    }
}
