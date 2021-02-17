using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays.Arrays
{
    public class ArrTasks
    {
        // 1. Is there a sum of two elems = main number
        public static bool IsSumOfTwoElems(IEnumerable<int> arr, int main)
        {
            var sortedArr = arr.OrderBy(el => el).ToList();

            var i = 0;
            var j = sortedArr.Count - 1;

            while (i < j)
            {
                var sum = sortedArr[i] + sortedArr[j];

                if (sum < main)
                    i++;
                else if (sum > main)
                    j--;
                else
                {
                    Console.WriteLine($"There are {main} of sum sortedArr[{i}] = {sortedArr[i]} and sortedArr[{j}] = {sortedArr[j]}");
                    return true;
                }
                    
            }

            Console.WriteLine("There are no sum");
            return false;
        }
        
        // 2. Most common number in array
        public static IEnumerable<int> MostCommonNumber(IEnumerable<int> arr)
        {
            var mostCommonDict = arr.GroupBy(n => n)
                .ToDictionary(n => n.Key, v => 0);
            
            foreach (var key in arr)
                mostCommonDict[key]++;
            
            return mostCommonDict.Where(x => x.Value == mostCommonDict.Values.Max()).Select(x => x.Key);
        }
        
        
        // 3. Zikkurat
        public static void Zikkurat(int num)
        {
            Console.WriteLine("\nZikkurat:");
            
            if (num <= 0)
                return;

            var border = num * 2 - 1;

            int[,] finalMatrix = new int[border, border];

            for (var i = 1; i < border; i++)
            {
                var newBorder = border - i + 1;

                for (var j = i - 1; j < newBorder; j++)
                {
                    for (var k = i - 1; k < newBorder; k++)
                    {
                        finalMatrix[j, k] = i;
                    }
                }

            }
            
            for (var i = 0; i < border; i++)
            {
                for (var j = 0; j < border; j++)
                {
                    Console.Write($"{finalMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        
        // 3. Max Multiply
        public static int MaxMultiply(IEnumerable<int> arr)
        {
            var orderedArr = arr.OrderByDescending(el => el).ToList();

            return orderedArr.Count > 1 ? orderedArr[0] * orderedArr[1] : -1;
        }
        
        // 5. Snake
        public static void Snake(int num)
        {
            Console.WriteLine("\nSnake:");
            
            if (num <= 0)
                return;

            // num^2 
            var border = (int)Math.Pow(num, 2);

            // matrix with snake in the end
            int[,] finalMatrix = new int[num, num];

            var fourCounter = 0; // four ways to print numbers

            var row = 0; // matrix rows
            var col = 0; // matrix cols
            var module = num - 1; // module to count for each row and col
            var moduleCounter = 0; // count module from 0 to num - 1

            // one loop from 1 to num^2 
            for (var i = 1; i <= border; i++)
            {
                // switch 4 different ways
                switch (fourCounter)
                {
                    // →
                    case 0:
                    {
                        finalMatrix[row, col] = i; // matrix[i,j] element = i value of given number
                        col++; // add cols to move right →
                        moduleCounter++; // increment module
                        if (moduleCounter == module)
                        {
                            fourCounter++; // change way
                            moduleCounter = 0; // start count module again from 0
                        }

                        break;
                    }
                    // ↓
                    case 1:
                    {
                        finalMatrix[row, col] = i;
                        row++; // add rows to move down ↓
                        moduleCounter++;
                        if (moduleCounter == module)
                        {
                            fourCounter++;
                            moduleCounter = 0;
                        }

                        break;
                    }
                    // ←
                    case 2:
                    {
                        finalMatrix[row, col] = i;
                        col--; // subtract cols to move left ←
                        moduleCounter++;
                        if (moduleCounter == module)
                        {
                            fourCounter++;
                            moduleCounter = 0;
                        }

                        break;
                    }
                    // ↑
                    case 3:
                    {
                        finalMatrix[row, col] = i;
                        row--; // subtract rows to move top ↑
                        moduleCounter++;
                        if (moduleCounter == module)
                        {
                            fourCounter = 0; // change way to zero to move right again
                            row++; // increment row cause we need next row
                            col++; // increment col cause we need next col

                            module -= 2; // decrease module by too for new 4 ways loop
                            moduleCounter = 0; // start count module from 0
                        }

                        break;
                    }
                }
            }
            
            for (var i = 0; i < num; i++)
            {
                for (var j = 0; j < num; j++)
                {
                    Console.Write($"{finalMatrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        
        // 6. All even numbers
        public static void AllEven(IEnumerable<int> arr)
        {
            var evenNumbers = arr.Where(el => el % 2 == 0);
            
            Console.WriteLine($"\nAll even: ");
            foreach (var el in evenNumbers)
                Console.Write($"{el} ");
        }
        
        // 7. How much 1 in the right site of each 0, find sum of all numbers (12 + 11 + 6 + 3 + 2 + 1 = 35)
        public static void CountOnes()
        {
            int[] arr = { 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1 };
            var counter = 0;
            var sum = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    counter++;
                else
                    sum += counter;
            }
            
            Console.WriteLine($"\nSum = {sum}");
            Console.WriteLine();
        }
        
        
        // 8. Move all zeros to the end
        public static void Zeros(int[] arr)
        {
            var i = 0;
            var j = arr.Count() - 1;
            
            while (i < j)
            {
                if (arr[i] == 0 && arr[j] != 0)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
                else if (arr[i] == 0 && arr[j] == 0)
                    j--;
                else
                    i++;
            }

            Console.WriteLine($"\nAll zeros: ");
            foreach (var el in arr)
                Console.Write($"{el} ");
        }
        
        private static void Swap(ref int first, ref int second)
        {
            var temp = first; 
            first = second; 
            second = temp; 
        }
        
        // 9. Array only with duplicates
        public static void Duplicates(List<int> arr)
        {
            var dupList = new List<int>();

            var sortedList = arr.OrderBy(el => el).ToList();

            for (var i = 0; i < arr.Count - 1; i++)
            {
                if (sortedList[i] == sortedList[i + 1] && !dupList.Contains(arr[i]))
                {
                    dupList.Add(arr[i]);
                }
            }

            Console.WriteLine($"\nDuplicates: ");
            foreach (var el in dupList)
                Console.Write($"{el} ");
        }
    }
}