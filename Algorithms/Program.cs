using System;
using System.Collections.Generic;
using System.Diagnostics;
using Arrays.Sorting;
using Arrays.FactorialFib;
using Arrays.Search;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Show how sorting algorithms work
            SortingExamples();
            
            // Show how custom linked list works
            LinkedListExample();
            
            // Show how 'factorial' and 'fibonachi' algorithms work
            FibonachiFactorialExample();

            // Show how 'binary search' works
            BinarySearchExample();
        }

        public static void SortingExamples()
        {
            int[] integerValues1 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 }; 
            int[] integerValues2 = { 11, -12, 42, 0, -1, -90, 68, -6, 9 }; 
            int[] integerValues3 = { -10, 5, 18, 0, -30, -10, 92, 16, -9 }; 
            int[] integerValues4 = { 25, -31, 10, 0, -40, 19, 5, -3, -20 }; 
            
            SelectionSort.Sort(integerValues1); 
            InsertionSort.Sort(integerValues2);
            BubbleSort.Sort(integerValues3);
            QuickSort.Sort(integerValues4);
            
            Console.WriteLine(String.Join(" | ", integerValues1)); 
            Console.WriteLine(String.Join(" | ", integerValues2)); 
            Console.WriteLine(String.Join(" | ", integerValues3)); 
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
            for (long i = 0; i < 100000000; i++)
                myArr.Add(i);

            myArr.Sort();

            // Binary search
            stopWatch.Start();
            long founded = BinarySearch.Binary(myArr, 99999980);
            Console.WriteLine("Founded number: " + founded);
            stopWatch.Stop();

            var ts = stopWatch.ElapsedMilliseconds;
            Console.WriteLine("RunTime: " + ts);
        }
    }
}