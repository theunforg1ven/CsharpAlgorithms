using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Arrays.Arrays;
using Arrays.Dynamic;
using Arrays.FactorialFib;
using Arrays.Graphs;
using Arrays.ProgHubTests;
using Arrays.Search;
using Arrays.Sorting;
using Arrays.Strings;

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
            //GraphBfsExample();

            // Dynamic programming backpack
            //BackpackExample();

            // Permute of string chars
            //PermuteExample();

            // Different recursive tasks
            //RecursionExample();
            
            // Different string tasks
            StringsExample();
            
            // Turing task
            //TuringExample();
            
            // Array tasks
            //ArraysExample();
            
            // Recursive Hanoi Tower
            //var towerWorks = new VisualHanoiTower();

            // deconstructring
            //(string name, int number) = ("Tom", 32);
            // Console.WriteLine($"{name} {number}");

            Console.ReadKey();
        }

        public static void ArraysExample()
        {
            Console.WriteLine("\nArray Algorithm:");

            var arr1 = new List<int> {1, 2, 4, 4};
            var arr2 = new List<int> {1, 2, 4, 9};
            var arr3 = new List<int> {1, 3, 8, 5, 10, 3, 2, 4, 15};

            ArrTasks.IsSumOfTwoElems(arr1, 8);
            ArrTasks.IsSumOfTwoElems(arr2, 8);
            ArrTasks.IsSumOfTwoElems(arr3, 10);

            Console.WriteLine("\nMost common:");
            var arr4 = new List<int> {1, 2, 4, 4};
            var arr5 = new List<int> {1, 2, 4, 9};
            var arr6 = new List<int> {1, 1, 4, 1, 10, 3, 4, 4, 15};
            var res1 = ArrTasks.MostCommonNumber(arr4);
            var res2 = ArrTasks.MostCommonNumber(arr5);
            var res3 = ArrTasks.MostCommonNumber(arr6);
            Console.WriteLine($"Arr4 values:");
            foreach (var el in res1)
                Console.Write($"{el} ");
            Console.WriteLine($"\nArr5 values:");
            foreach (var el in res2)
                Console.Write($"{el} ");
            Console.WriteLine($"\nArr6 values:");
            foreach (var el in res3)
                Console.Write($"{el} ");
            Console.WriteLine();

            ArrTasks.Zikkurat(4);
            ArrTasks.Zikkurat(5);

            Console.WriteLine("\nMax Multiply:");
            Console.WriteLine($"Max mult from arr 1: {ArrTasks.MaxMultiply(arr1)} ");
            Console.WriteLine($"Max mult from arr 2: {ArrTasks.MaxMultiply(arr2)} ");
            Console.WriteLine($"Max mult from arr 3: {ArrTasks.MaxMultiply(arr3)} ");

            ArrTasks.Snake(5);
            ArrTasks.Snake(6);
            ArrTasks.Snake(7);
            ArrTasks.Snake(8);

            ArrTasks.AllEven(arr1);
            ArrTasks.AllEven(arr2);
            ArrTasks.AllEven(arr3);

            ArrTasks.CountOnes();

            var arrzero1 = new[] {3, 0, 0, 1, 2, 0, 5, 4, 3, 3};
            var arrzero2 = new[] {3, 0, 0, 1, 2, 0, 5, 0, 3, 0};
            var arrzero3 = new[] {3, 1, 1, 1, 2, 5, 0, 4, 0, 0};
            ArrTasks.Zeros(arrzero1);
            ArrTasks.Zeros(arrzero2);
            ArrTasks.Zeros(arrzero3);
            
            var dup1 = new List<int> {1, 3, 2, 2, 3, 0};
            var dup2 = new List<int> {1, 0, 2, 0, 3, 1};
            var dup3 = new List<int> {1, 3, 1, 2, 3, 0};
            ArrTasks.Duplicates(dup1);
            ArrTasks.Duplicates(dup2);
            ArrTasks.Duplicates(dup3);
            
            ArrTasks.OneAndZero();
        }
        
        public static void TuringExample()
        {
            Console.WriteLine("\nTuring Algorithm:");

            var str = "Turing";
            var turing = new TuringTask();
            var number=  turing.Turing(str);
            Console.WriteLine($"Index of 'Turing' word = {number}");
        }

        public static void StringsExample()
        {
            Console.WriteLine("\nString Algorithm:");

            var value1 = StrTasks.RemoveDuplicateChars("Csharpcsharp");
            var value2 = StrTasks.RemoveDuplicateChars("Google");
            var value3 = StrTasks.RemoveDuplicateChars("Yahoo");
            var value4 = StrTasks.RemoveDuplicateChars("CNN");
            var value5 = StrTasks.RemoveDuplicateChars("Line1\nLine2\nLine3");
 
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);
            Console.WriteLine(value5);

            var str = "Csha rpcs harp";
            Console.WriteLine($"Count words in string: {str} = {StrTasks.CountWords(str)}");

            var palindrome = "kayak";
            var palArr = palindrome.ToCharArray();
            Console.Write($"Check if string is palindrome: {palindrome}");
            StrTasks.IsPalindrome(palArr);

            var isUnique = "abbcd";
            Console.Write($"String {isUnique} has only unique cahracters: {StrTasks.IsAllUnique(isUnique)}\n");

            var test1Str = "Silent";
            var test2Str = "Listen";
            var test3Str = "something else";
            StrTasks.IsAnagram(test1Str, test2Str);
            StrTasks.IsAnagram(test2Str, test3Str);
            StrTasks.IsAnagram(test1Str, test3Str);
            
            var isUniqueFirst = "abcbcadfytygfra";
            Console.Write($"First unique char from {isUniqueFirst} : {StrTasks.FindFirstUniqueSymbol(isUniqueFirst)}\n");
            
            var a = "abc";
            var b = "abccba";
            var c = "abcdcba";
            var d = "aabcbbcaccc";
            Console.Write($"Number of strings from a='{a}' and b='{b}': {StrTasks.StringConstructions(a, b)}\n");
            Console.Write($"Number of strings from a='{a}' and b='{c}': {StrTasks.StringConstructions(a, c)}\n");
            Console.Write($"Number of strings from a='{a}' and b='{d}': {StrTasks.StringConstructions(a, d)}\n");
            
            var integer1 = 1234;
            var width1 = 2;
            var width2 = 4;
            var width3 = 5;
            var width4 = 10;
            Console.Write($"New string from integer {integer1} with width {width1}: {StrTasks.StringFromIntWithWidth(integer1, width1)}\n");
            Console.Write($"New string from integer {integer1} with width {width2}: {StrTasks.StringFromIntWithWidth(integer1, width2)}\n");
            Console.Write($"New string from integer {integer1} with width {width3}: {StrTasks.StringFromIntWithWidth(integer1, width3)}\n");
            Console.Write($"New string from integer {integer1} with width {width4}: {StrTasks.StringFromIntWithWidth(integer1, width4)}\n");
            
            var one1 = "ceoydefthf5iyg5h5yts";
            var ano1= "codefights";
            var one2 = "addbyca";
            var ano2 = "abcd";
            Console.Write($"Can get a string?: {StrTasks.OneStringFromAnother(one1, ano1)}\n");
            Console.Write($"Can get a string?: {StrTasks.OneStringFromAnother(one2, ano2)}\n");
            
            var arr = new List<string> {"aba", "aa", "ad", "dfg", "ava"};
            var resTen = StrTasks.LongestStrings(arr);
            Console.Write("Longest strings: ");
            resTen.ForEach(el => Console.Write($"{el} "));
            Console.WriteLine();

            var rleStr = "AVVVBBBVVXDHJFFFFDDDDDDHAAAAJJJDDSLSSSDDDDK";
            Console.Write($"Result rle of str:{rleStr} = {StrTasks.StringRle(rleStr)}\n");

            var chstr1 = "aaa bbb ccc";
            var chstr2 = "111,  222 333";
            var chstr3 = "xxx yyy zzz";
            Console.Write($"Change order 1: {StrTasks.ChangeWords(chstr1)}\n");
            Console.Write($"Change order 2: {StrTasks.ChangeWords(chstr2)}\n");
            Console.Write($"Change order 3: {StrTasks.ChangeWords(chstr3)}\n");

            StrTasks.FinonachiAfter(10, 15);
        }

        public static void RecursionExample()
        {
            Console.WriteLine("\nRecursion Algorithm:");

            var n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{RecursiveTasks.T1Progression(i)} ");
            }

            var sum = RecursiveTasks.T2ProgressionSum(5, 2);
            Console.Write($"\nSum = {sum} ");

            var str = "abcdefg";
            var arr = str.ToCharArray();
            Console.WriteLine();
            RecursiveTasks.T3ReverseStr(arr);
            
            var a = new[] { 0, 5, 6, 1, 9, 7, 8, 3, 2, 4 };
            Console.WriteLine("Index: " + RecursiveTasks.T4IndexOfMax(a, a.Length - 1));

            var number = 145;
            Console.WriteLine($"Sum of contained digits of the number {number} = {RecursiveTasks.T22SumOfContainedDigits(number)}");
            Console.WriteLine($"Sum of digits of the number {number} = {RecursiveTasks.T22SumOfDigits(number)}");
            Console.Write($"Convert decimal to binary {number} = ");
            RecursiveTasks.DecimalToBinary(number);
            
            var numberExp = 10;
            var exp = 3;
            Console.WriteLine($"Power of number {numberExp} = {RecursiveTasks.PowerOfNumber(numberExp, exp)}");
            
            var a1 = 10;
            var b1 = 135;
            Console.WriteLine($"Greatest common divisor of numbers a1: {a1} and b1: {b1} = {RecursiveTasks.FindGCD(a1, b1)}");
        }

        public static void PermuteExample()
        {
            Console.WriteLine("\nPermute Algorithm:");

            var str = "abc";
            char[] arr = str.ToCharArray();
            Permute.GetPer(arr);
        }

        public static void BackpackExample()
        {
            Console.WriteLine("\nBackpack Algorithm:");

            var items = new List<Item>
            {
                new Item("Player", 4, 3000),
                new Item("Laptop", 3, 2000),
                new Item("Guitar", 1, 1500),
            };

            var bp = new Backpack();
            var weight = 4;

            var finalList = bp.GetBestBackpackItems(weight, items, out int result);

            Console.WriteLine($"Maximum weight is {weight}");

            foreach (var item in finalList)
                Console.WriteLine($"Added item {item.Name} with weight: {item.Weigth} and with price: {item.Price}");

            Console.WriteLine($"Final items weight is {finalList.Select(i => i.Weigth).Sum()}");
            Console.WriteLine($"Final items price is {result}");
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