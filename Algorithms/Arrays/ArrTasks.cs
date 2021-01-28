using System.Collections.Generic;

namespace Arrays.Arrays
{
    public class ArrTasks
    {
        // 1. Is there a sum of two elems = main number
        public static string IsSumOfTwoElems(List<int> arr, int main)
        {
            var result = new StringBuilder();
            
            foreach (var elem in currString)
            {
                if (!result.ToString().Contains(elem))
                {
                    result.Append(elem);
                }
            }

            return result.ToString();
        }
    }
}