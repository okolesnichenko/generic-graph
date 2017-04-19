using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph<T> where T:struct
    {
        Queue<Vertex<T>> queueOfVertex = new Queue<Vertex<T>>();
        bool visit = false;
        string numberOfVertex = "";

        public void AddVertex(List<Vertex<T>> vertexes, T data, int x, int y)
        {
            List<Vertex<T>> listOfEdges = new List<Vertex<T>>();
            Vertex<T> newVertex = new Vertex<T>(x, y, data, visit, listOfEdges);
            vertexes.Add(newVertex);
        }

        public void AddEdge(List<Edge<T>> edges, Vertex<T> firstVertex, Vertex<T> secondVertex, T data)
        {
            Edge<T> newEdge = new Edge<T>(firstVertex, secondVertex, data);
            edges.Add(newEdge);
        }

        public void Dfs(Vertex<T> vertex) //глубина
        {
            numberOfVertex += Convert.ToString(vertex.data) + " ";
            vertex.visit = true;
            for(int i = 0; i<vertex.listOfEdges.Count; i++)
            {
                if(!vertex.listOfEdges[i].visit)
                {
                    Dfs(vertex.listOfEdges[i]);
                }
            }
        }

        public void Bfs(Vertex<T> vertex)
        {
            queueOfVertex.Enqueue(vertex);
            vertex.visit = true;
            while(queueOfVertex.Count!=0)
            {
                vertex = queueOfVertex.Dequeue();
                numberOfVertex += Convert.ToString(vertex.data) + " ";
                for (int i = 0; i < vertex.listOfEdges.Count; i++)
                {
                    if (!vertex.listOfEdges[i].visit)
                    {
                        queueOfVertex.Enqueue(vertex);
                        vertex.listOfEdges[i].visit = true;
                    }
                }
            }
        }

        public void Dejkstra(List<Vertex<T>> vertexes, int [,] matrix, int startVertex )
        {



        }
    }
}
