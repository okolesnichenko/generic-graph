using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP22
{ 
    public class Graph<T> where T:struct
    {
        Queue<Vertex<T>> queueOfVertex = new Queue<Vertex<T>>();
        bool visit = false;
        public string numberOfVertex = "";

        public void AddVertex(List<Vertex<T>> vertexes, int index, T data, int x, int y)
        {
            int sumRoad = int.MaxValue;
            List<Vertex<T>> listOfEdges = new List<Vertex<T>>();
            Vertex<T> newVertex = new Vertex<T>(x, y, index, data, visit, sumRoad, listOfEdges);
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
                numberOfVertex +=Convert.ToString(vertex.data) + " ";
                for (int i = 0; i < vertex.listOfEdges.Count; i++)
                {
                    if (!vertex.listOfEdges[i].visit)
                    {
                        queueOfVertex.Enqueue(vertex.listOfEdges[i]);
                        vertex.listOfEdges[i].visit = true;
                    }
                }
            }
        }

        public List<Edge<T>> Kraskala(List<Vertex<T>> vertexs, List<Edge<T>> edges)
        {
            List<Edge<T>> result = new List<Edge<T>>();
            List<Vertex<T>> tree_id = new List<Vertex<T>>();
            for(int i = 0; i<vertexs.Count;i++)
            {
                tree_id.Add(vertexs[i]);
            }

            for (int i = 0; i < edges.Count; i++)
            {
                Vertex<T> a = edges[i].firstVertex;
                Vertex<T> b = edges[i].secondVertex;
                if (tree_id[a.index] != tree_id[b.index])
                {
                    result.Add(new Edge<T>(a, b, edges[i].data));
                    Vertex<T> old_id = tree_id[b.index], new_id = tree_id[a.index];
                    for (int j = 0; j < vertexs.Count; ++j)
                    {
                        if (tree_id[j] == old_id)
                        {
                            tree_id[j] = new_id;
                        }
                    }
                }
            }
            return result;
        }

        public void Dijkstra(List<Vertex<T>> vertexs, int[,] matrix, int rand)
        {
            vertexs[rand].sumRoad = 0;
            for (int i = 0; i < vertexs.Count; i++)
            {
                int min = 0;
                for (int j = 0; j < vertexs.Count; j++)
                {
                    if ((!vertexs[j].visit) && (vertexs[j].sumRoad < vertexs[min].sumRoad))
                    {
                        min = j;
                    }
                }
                if (min == int.MaxValue) { break; }
                vertexs[min].visit = true;
                for (int e = 0; e < vertexs[min].listOfEdges.Count; e++)
                {
                    if (vertexs[min].sumRoad + matrix[vertexs[min].index, vertexs[min].listOfEdges[e].index] < vertexs[min].listOfEdges[e].sumRoad)
                        vertexs[min].listOfEdges[e].sumRoad = vertexs[min].sumRoad + matrix[vertexs[min].index, vertexs[min].listOfEdges[e].index];
                }
            }
        }
    }
}
