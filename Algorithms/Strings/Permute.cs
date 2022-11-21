using System;

namespace Arrays.Strings
{
	public class Permute
	{
        public static void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        private static void GetPer(char[] list, int recursionDepth, int maxDepth)
        {
            if (recursionDepth == maxDepth)
            {
                Console.WriteLine(list);
            }
            else
			{
                for (int i = recursionDepth; i <= maxDepth; i++)
                {
                    Swap(ref list[recursionDepth], ref list[i]);
                    GetPer(list, recursionDepth + 1, maxDepth);
                    Swap(ref list[recursionDepth], ref list[i]);
                }
            }
                
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) 
                return;

            (a, b) = (b, a);
        }

    }
}
