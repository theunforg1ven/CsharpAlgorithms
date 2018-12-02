using System;

namespace Arrays.Graphs
{
    public static class Dijkstra
    {
        public static void DijkstraAlgorithm(int[,] graph, int source, int verticesCount)
        {
            // create needed arrays where size is amount of vertices
            var distance = new int[verticesCount];
            var shortestPathTree = new bool[verticesCount];

            // initialize first distance and shortest path tree
            for (var i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTree[i] = false;
            }

            // algorithm starts from this point
            distance[source] = 0;

            // build an array of shortest ways
            for (var i = 0; i < verticesCount - 1; i++)
            {
                // min distance and shortest path on current step
                var minDistance = MinimumDistance(distance, shortestPathTree, verticesCount);
                shortestPathTree[minDistance] = true;

                // place all available vertice values on the current step
                for (var vertice = 0; vertice < verticesCount; vertice++)
                    if (!shortestPathTree[vertice] && Convert.ToBoolean(graph[minDistance, vertice])
                                                   && distance[minDistance] != int.MaxValue
                                                   && distance[minDistance] + graph[minDistance, vertice] < distance[vertice])
                    {
                        // set value of each available vertice
                        distance[vertice] = distance[minDistance] + graph[minDistance, vertice];
                    }
                        
            }

            // print final algorithm result in console
            PrintResult(distance, verticesCount);
        }

        private static  int MinimumDistance(int[] distance, bool[] shortestPathTree, int verticesCount)
        {
            // firstly min distance is "infinity"
            var min = int.MaxValue;
            var minIndex = 0;

            // check all available vertices and find index of min vertice
            for (var vertice = 0; vertice < verticesCount; vertice++)
            {
                // if path tree elem is 'false' and distance value is smaller than min
                if (shortestPathTree[vertice] == false && distance[vertice] <= min)
                {
                    // min element is current is current vertice value 
                    min = distance[vertice];
                    
                    // min index is index of current min vertice value
                    minIndex = vertice;
                }
            }

            // return index you found
            return minIndex;
        }

        private static void PrintResult(int[] distance, int verticesCount)
        {
            // print number of vertice and the shortest way
            for (var i = 0; i < verticesCount; i++)
                Console.WriteLine($"{i}: {distance[i]}");
        }
    }
}