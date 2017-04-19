using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP22
{
    public class Vertex<T> where T:struct
    {
        public List<Vertex<T>> listOfEdges;
        public T data;
        public int index;
        public bool visit;
        public int x, y;
        public int sumRoad;
        public Vertex(int x, int y, int index, T data, bool visit, int sumRoad, List<Vertex<T>> listOfEdges)
        {
            this.x = x;
            this.y = y;
            this.index = index;
            this.data = data;
            this.visit = visit;
            this.sumRoad = sumRoad;
            this.listOfEdges = listOfEdges;
        }
    }
}
