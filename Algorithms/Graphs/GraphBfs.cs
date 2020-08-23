using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Graphs
{
	public class GraphBfs
	{
		public List<GraphVertex> VisitedVertices { get; set; }

		public Queue<GraphVertex> GraphVertices { get; set; }

		public Graph Graph { get; set; }

		public GraphBfs()
		{
			VisitedVertices = new List<GraphVertex>();
			GraphVertices = new Queue<GraphVertex>();
		}

		public bool FindVertexBfs(Graph graph, string vertexName)
		{
			var graphQueue = AddGraph(graph);

			while (graphQueue != null)
			{
				var vertice = graphQueue.Dequeue();
				if (!VisitedVertices.Contains(vertice))
				{
					if (vertice.Name == vertexName)
					{
						Console.WriteLine($"Vertice {vertexName} was found! Yeeeeee");
						return true;
					}
					else
					{
						var childVertices = vertice.Edges.Select(e => e.ConnectedVertex).Where(v => !VisitedVertices.Contains(v));
						foreach (var verticeChild in childVertices)
						{
							Console.WriteLine($"Vertice child {verticeChild.Name} of {vertice.Name}");
							graphQueue.Enqueue(verticeChild);
						}
						VisitedVertices.Add(vertice);
					}
				}	
			}

			return false;
		}

		private Queue<GraphVertex> AddGraph(Graph graph)
		{
			Graph = graph;
			foreach (var vertex in Graph.Vertices)
			{
				GraphVertices.Enqueue(vertex);
			}

			return GraphVertices;
		}
	}
}
