using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Graphs
{
	public class GraphVertex
	{
        public string Name { get; }

        public List<GraphEdge> Edges { get; }

        public GraphVertex(string vertexName)
        {
            Name = vertexName;
            Edges = new List<GraphEdge>();
        }

        public void AddEdge(GraphVertex vertex, int edgeWeight)
        {
            AddEdge(new GraphEdge(vertex, edgeWeight));
        }

        private void AddEdge(GraphEdge newEdge)
        {
            Edges.Add(newEdge);
        } 

        public override string ToString() => Name;
    }
}
