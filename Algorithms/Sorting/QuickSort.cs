using System;

namespace Arrays.Sorting
{
    public static class QuickSort
    {
        public static void Sort<T>(T[] array) where T : IComparable 
        { 
            Sort(array, 0, array.Length - 1); 
        }
        
        private static void Sort<T>(T[] array, int lower, int upper) where T : IComparable 
        { 
            if (lower < upper) 
            { 
                int p = Partition(array, lower, upper); 
                Sort(array, lower, p); 
                Sort(array, p + 1, upper); 
            } 
        }
        
        private static int Partition<T>(T[] array, int lower, int upper) where T : IComparable 
        { 
            T pivot = array[lower]; // or: T pivot = array[(lower + upper) / 2];
            
            do 
            { 
                while (array[lower].CompareTo(pivot) < 0) 
                    lower++; 
                
                while (array[upper].CompareTo(pivot) > 0) 
                    upper--; 
            
                if (lower >= upper)  
                    break; 
                
                Swap(array, lower, upper); 
            } 
            
            while (lower <= upper); 
                
            return upper; 
        }
        
        private static void Swap<T>(T[] array, int first, int second)
        {
            var temp = array[first]; 
            array[first] = array[second]; 
            array[second] = temp; 
        }
    }
}