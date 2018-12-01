using System;

namespace Arrays.Sorting
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                var minIndex = i; // index of minimal element
                var minvalue = array[i]; // minimal element value

                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minvalue) < 0)
                    {
                        minIndex = j; // new index of minimal element
                        minvalue = array[j]; // new minimal element value 
                    }
                }
                
                Swap(array, i, minIndex);
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