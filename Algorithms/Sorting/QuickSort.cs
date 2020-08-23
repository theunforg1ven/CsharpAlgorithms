using System;

namespace Arrays.Sorting
{
    public static class QuickSort
    {
        public static void Sort<T>(T[] array) where T : IComparable 
        { 
            // initialize sorting
            Sort(array, 0, array.Length - 1); 
        }
        
        private static void Sort<T>(T[] array, int lower, int upper) where T : IComparable 
        { 
            // if condition is true
            if (lower < upper) 
            { 
                // find element to divide array into 2 parts
                int p = Partition(array, lower, upper);
                
                // lower part
                Sort(array, lower, p);
                
                // upper part
                Sort(array, p + 1, upper); 
            } 
        }
        
        private static int Partition<T>(T[] array, int lower, int upper) where T : IComparable 
        { 
            // get pivot element as lower 
            var pivot = array[lower]; // or: T pivot = array[(lower + upper) / 2];
            
            // loop to place lower than pivot element before 'pivot'
            // and greater elements after 'pivot'
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
            
            // condition - while lower elem is 'lower' than upper
            while (lower < upper); 
                
            // return partition element
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