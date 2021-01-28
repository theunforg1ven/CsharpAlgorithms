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
    }
}