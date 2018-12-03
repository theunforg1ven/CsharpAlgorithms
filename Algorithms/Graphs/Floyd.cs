using System;

namespace Arrays.Graphs
{
    public static class Floyd
    {
        public static void FloydAlgorithm(int[,] graph, int amount)
        {
            for (var k = 0; k < amount; k++)
                for (var i = 0; i < amount; i++)              
                    for (var j = 0; j < amount; j++)      
                        // if condition is true - change current graph element value
                        if (graph[i, k] + graph[k, j] < graph[i, j])
                            graph[i, j] = graph[i, k] + graph[k, j];

            // print result
            PrintResult(graph, amount);
        }
        
        private static void PrintResult(int[,] graph, int amount)
        {
            // print final matrix
            for (var i = 0; i < amount; i++)
            {
                for (var j = 0; j < amount; j++)
                {
                    if (graph[i, j] == 9999)
                        Console.Write("inf".PadLeft(7));
                    else
                        Console.Write(graph[i, j].ToString().PadLeft(7));
                }
 
                Console.WriteLine();
            }   
        }
    }
}