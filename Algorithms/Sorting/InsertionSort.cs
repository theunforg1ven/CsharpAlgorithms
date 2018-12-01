using System;

namespace Arrays.Sorting
{
    public static class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (var i = 1; i < array.Length; i++)
            {
                var j = i;
                // while previous element is smaller then current
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0) 
                {
                    Swap(array, j, j - 1); // swap them
                    j--; // step back
                }
            }
        }

        private static void Swap<T>(T[] array, int first, int second)
        {
            var temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}