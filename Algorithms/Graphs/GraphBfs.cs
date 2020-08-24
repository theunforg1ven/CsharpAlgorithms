using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Graphs
{
	public class GraphBfs
	{
		private List<GraphVertex> _visitedVertices;
		private Queue<GraphVertex> _graphVertices;
		private Graph _graph;

		public GraphBfs()
		{
			_visitedVertices = new List<GraphVertex>();
			_graphVertices = new Queue<GraphVertex>();
		}

		public bool FindVertexBfs(Graph graph, string vertexName)
		{
			var graphQueue = AddGraph(graph);

			while (graphQueue != null)
			{
				var vertice = graphQueue.Dequeue();
				if (!_visitedVertices.Contains(vertice))
				{
					if (vertice.Name == vertexName)
					{
						Console.WriteLine($"Vertice {vertexName} was found in bfs! Yeeeeee\n");
						return true;
					}
					else
					{
						var childVertices = vertice.Edges.Select(e => e.ConnectedVertex).Where(v => !_visitedVertices.Contains(v));
						foreach (var verticeChild in childVertices)
						{
							Console.WriteLine($"Vertice child {verticeChild.Name} of {vertice.Name}");
							graphQueue.Enqueue(verticeChild);
						}
						_visitedVertices.Add(vertice);
					}
				}	
			}

			return false;
		}

		private Queue<GraphVertex> AddGraph(Graph graph)
		{
			_graph = graph;
			foreach (var vertex in _graph.Vertices)
			{
				_graphVertices.Enqueue(vertex);
			}

			return _graphVertices;
		}
	}
}
