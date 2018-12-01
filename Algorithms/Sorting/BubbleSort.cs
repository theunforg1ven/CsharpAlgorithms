using System;

namespace Arrays.Sorting
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (var i = 0; i < array.Length; i++)
            {
                var isAnyChange = false; 
                
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        isAnyChange = true;
                        Swap(array, j, j + 1);
                    }
                }

                // when no changes are discovered
                if (!isAnyChange) 
                    break;
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