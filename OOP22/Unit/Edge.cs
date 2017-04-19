using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP22
{
    public class Edge<T> where T : struct
    {
        public Vertex<T> firstVertex, secondVertex;
        public T data;
        public Edge(Vertex<T> firstVertex, Vertex<T> secondVertex, T data)
        {
            this.firstVertex = firstVertex;
            this.secondVertex = secondVertex;
            this.data = data;
        }
    }
}
