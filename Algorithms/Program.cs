using System;
using System.Collections.Generic;
using System.Diagnostics;
using Arrays.FactorialFib;
using Arrays.Graphs;
using Arrays.Search;
using Arrays.Sorting;


namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Show how sorting algorithms work
            //SortingExamples();

            // Show how custom linked list works
            // LinkedListExample();

            // Show how 'factorial' and 'fibonachi' algorithms work
            //FibonachiFactorialExample();

            // Show how 'binary search' works
            //BinarySearchExample();

            // Show how 'Dijkstra' algorithm works
            // DijkstraExample();

            // Show how 'Floyd–Warshall' algorithm works
            // FloydExample();

            // Graps Bfs
            GraphBfsExample();

            Console.ReadKey();
        }

        public static void FloydExample()
        {
            Console.WriteLine("\nFloyd Algorithm:");
            
            // found this matrix in the internet
            int[,] graph = {
                { 0,   6,  9999, 11 },
                { 9999, 0,   4, 9999 },
                { 9999, 9999, 0,   2 },
                { 9999, 9999, 9999, 0 }
            };
            
            Floyd.FloydAlgorithm(graph, 4);
        }

        public static void GraphBfsExample()
        {
            Console.WriteLine("\nGraph Bfs Algorithm:");

            var g = new Graph();

            //добавление вершин
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddVertex("E");
            g.AddVertex("F");
            g.AddVertex("G");
            g.AddVertex("H");

            //добавление ребер
            g.AddEdge("A", "B", 22);
            g.AddEdge("A", "C", 33);
            g.AddEdge("B", "D", 61);
            g.AddEdge("B", "E", 47);
            g.AddEdge("C", "F", 93);
            g.AddEdge("C", "G", 11);
            g.AddEdge("E", "H", 79);


            var bfs = new GraphBfs();
            var path = bfs.FindVertexBfs(g, "C");

            var search = new GraphDfs();
            var pathDfs = search.DFS(g.Vertices[0], g.Vertices[7]);
        }

        public static void DijkstraExample()
        {
            Console.WriteLine("\nDijkstra Algorithm:");
            
            // found this matrix in the internet
            var graph = new [,]{
                {0, 4, 0, 0, 0, 0, 0, 8, 0}, 
                {4, 0, 8, 0, 0, 0, 0, 11, 0}, 
                {0, 8, 0, 7, 0, 4, 0, 0, 2}, 
                {0, 0, 7, 0, 9, 14, 0, 0, 0}, 
                {0, 0, 0, 9, 0, 10, 0, 0, 0}, 
                {0, 0, 4, 14, 10, 0, 2, 0, 0}, 
                {0, 0, 0, 0, 0, 2, 0, 1, 6}, 
                {8, 11, 0, 0, 0, 0, 1, 0, 7}, 
                {0, 0, 2, 0, 0, 0, 6, 7, 0}
            }; 
 
            Dijkstra.DijkstraAlgorithm(graph, 0, 9);
        }

        public static void SortingExamples()
        {
            int[] integerValues1 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 }; 
            int[] integerValues2 = { 11, -12, 42, 0, -1, -90, 68, -6, 9 }; 
            int[] integerValues3 = { -10, 5, 18, 0, -30, -10, 92, 16, -9 }; 
            int[] integerValues4 = { 25, -31, 10, 0, -40, 19, 5, -3, -20 }; 
            
            //SelectionSort.Sort(integerValues1); 
            //InsertionSort.Sort(integerValues2);
            //BubbleSort.Sort(integerValues3);
            QuickSort.Sort(integerValues4);
            
            //Console.WriteLine(String.Join(" | ", integerValues1)); 
            //Console.WriteLine(String.Join(" | ", integerValues2)); 
            //Console.WriteLine(String.Join(" | ", integerValues3)); 
            Console.WriteLine(String.Join(" | ", integerValues4));
        }

        public static void LinkedListExample()
        {
            var linkedint = new LinkedList.LinkedList<int> { 54, 32, 21, 40, 92 };
            foreach (var item in linkedint)
                Console.Write($"{item} ");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"Is list empty?: {linkedint.IsEmpty}");
            Console.WriteLine($"Count: {linkedint.Count}");
            Console.WriteLine($"Min element: {linkedint.Min()}");
            Console.WriteLine($"Max element: {linkedint.Max()}");

            linkedint.Add(57);
            linkedint.Remove(54);
            linkedint.AppendFirst(19);

            Console.WriteLine();
            foreach (var item in linkedint)
                Console.Write($"{item} ");

            linkedint.Reverse();

            Console.WriteLine(Environment.NewLine);
            foreach (var item in linkedint)
                Console.Write($"{item} ");
        }

        public static void FibonachiFactorialExample()
        {
            const int number = 7;

            // factorial
            Console.WriteLine($"{number}! = {GetFactorial.Factorial(number)}");
            Console.WriteLine("|************************************************************************|");

            // fibonachi 3
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine($"{ Fibonachi.FibonachiThree(i)}");
            }

            Console.WriteLine($"Fibonachi of {number} = {Fibonachi.FibonachiThree(number)}");
            Console.WriteLine("|************************************************************************|");

            // fibonachi 2
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine($"{ Fibonachi.FibonachiTwo(i)}");
            }

            Console.WriteLine($"Fibonachi of {number} = {Fibonachi.FibonachiTwo(number)}");
            Console.WriteLine("|************************************************************************|");
        }

        public static void BinarySearchExample()
        {
            var stopWatch = new Stopwatch();

            var myArr = new List<long>();
            for (long i = 0; i < 20; i++)
                myArr.Add(i);

            myArr.Sort();

            // Binary search
            stopWatch.Start();
            long founded = BinarySearch.Binary(myArr, 12);
            Console.WriteLine("Founded number: " + founded);
            stopWatch.Stop();

            var ts = stopWatch.ElapsedMilliseconds;
            Console.WriteLine("RunTime: " + ts);
        }
    }
}