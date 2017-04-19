using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Vertex<T> where T:struct
    {
        public List<Vertex<T>> listOfEdges;
        public T data;
        public bool visit;
        public int x, y;
        public Vertex(int x, int y, T data, bool visit, List<Vertex<T>> listOfEdges)
        {
            this.x = x;
            this.y = y;
            this.data = data;
            this.visit = visit;
            this.listOfEdges = listOfEdges;
        }
    }
}
