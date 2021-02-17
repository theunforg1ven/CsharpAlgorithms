using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.ProgHubTests
{
    public class TuringTask
    {
        private List<string> _permutations;

        public TuringTask()
        {
            _permutations = new List<string>();
        }

        public int Turing(string word)
        {
            var arr = word.ToCharArray();
            GetPer(arr);

            var wordsCount = _permutations.OrderBy(s => s)
                                                    .Distinct()
                                                    .ToList();

            var elem = wordsCount.FirstOrDefault(str => str == word);

            var indexOfElem = wordsCount.IndexOf(elem) + 1; // list starts from index 0 , but we need to take [0] element as [1] first element

            return indexOfElem;
        }
        
        private void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }
        
        private void GetPer(char[] list, int recursionDepth, int maxDepth)
        {
            if (recursionDepth == maxDepth)
            {
                _permutations.Add(new string(list));
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

            var temp = a;
            a = b;
            b = temp;
        }
    }
}
