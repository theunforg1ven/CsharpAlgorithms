using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Graphs
{
	public class GraphDfs
	{
        private HashSet<GraphVertex> _visited;
        private LinkedList<GraphVertex> _path;
        private GraphVertex _goal;

        public LinkedList<GraphVertex> DFS(GraphVertex start, GraphVertex goal)
        {
            _visited = new HashSet<GraphVertex>();
            _path = new LinkedList<GraphVertex>();
           _goal = goal;
            
            DFS(start);
            
            if (_path.Count > 0)
                _path.AddFirst(start);

            return _path;
        }

        private bool DFS(GraphVertex node)
        {
            if (node == _goal)
                return true;

            _visited.Add(node);

            foreach (var child in node.Edges.Select(e => e.ConnectedVertex).Where(e => !_visited.Contains(e)))
            {
                Console.WriteLine($"Vertice child {child.Name} of {node.Name}");
                if (DFS(child))
                {
                    if (child == _goal)
                        Console.WriteLine($"Vertice {child.Name} was found in dfs! Yeeeeee");
                    _path.AddFirst(child);
                    return true;
                }
            }
            return false;
        }
    }
}
