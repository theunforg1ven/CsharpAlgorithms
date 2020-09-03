using System;
using System.Collections.Generic;

namespace Arrays.Search
{
    public static class BinarySearch
    {
        public static T Binary<T>(List<T> array, T value) where T : IComparable
        {
            if (array.Count == 0)
                return default(T);

            var first = 0;
            var last = array.Count - 1;

            // amount of divide tries
            var tries = 0;

            while (first < last)
            {
                var middle = first + (last - first) / 2;

                if (value.CompareTo(array[middle]) <= 0) // if 'value' <= 'array[middle]'
                    last = middle;

                else                                     // if 'value' > 'array[middle]'
                    first = middle + 1;

                tries++;
            }

            if (value.CompareTo(array[last]) == 0)
            {
                Console.WriteLine($"Amount of tries: {tries}");
                return value;
            }
				
            else
                return default(T);
        } 
    }
}