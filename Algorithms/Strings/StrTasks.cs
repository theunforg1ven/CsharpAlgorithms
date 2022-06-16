using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Arrays.Strings
{
    public static class StrTasks
    {
        // 1. Remove duplicate chars from string
        public static string RemoveDuplicateChars(string currString)
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
        
        // 2. Check if two Strings are anagrams of each other
        public static void IsAnagram(string str1, string str2)
        {
            var arr1 = str1.ToLower().ToCharArray();
            var arr2 = str2.ToLower().ToCharArray();
            
            Array.Sort(arr1);
            Array.Sort(arr2);

            var newStr1 = new string(arr1);
            var newStr2 = new string(arr2);

            Console.WriteLine(newStr1 == newStr2
                                        ? $"Current strings {str1} and {str2} are anagrams"
                                        : $"Strings {str1} and {str2} are not anagrams");
        }
        
        // 3. Count number of words in a String
        public static int CountWords(string currString)
        {
            var words = currString.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        
        // 4. Check if string is Palindrome
        public static void IsPalindrome(char[] str)
        {
            int i = 0;
            int j = str.Length - 1;
            IsPalindrome(str, i, j);
        }

        private static void IsPalindrome(char[] str, int i, int j)
        {
            if (i >= j)
            {
                Console.WriteLine(" is a palindrome");
            }
            else if (str[i] != str[j])
            {
                Console.WriteLine(" is NOT a palindrome");
            }
            else
            {
                IsPalindrome(str, i + 1, j - 1);
            }

        }

        // 5. Determine if the string has all unique characters
        public static bool IsAllUnique(string currString)
        {
            return currString.ToCharArray().Distinct().Count() == currString.Length;
        }
        
        // 6. Find first unique symbol in string
        public static char FindFirstUniqueSymbol(string currString)
        {
            var result = currString.GroupBy(c => c)
                                                    .ToDictionary(c => c.Key, v => 0);
            
            foreach (var c in currString)
                result[c]++;

            return result.FirstOrDefault(c => c.Value == 1).Key;
        }
        
        // 7. How many strings "a" can be constructed from chars in string "b" [ a = 'abc', b = 'abccba', result = 2]
        public static int StringConstructions(string a, string b)
        {
            var bDict =  b.GroupBy(c => c)
                            .ToDictionary(c => c.Key, v => 0);

            foreach (var key in b)
                bDict[key]++;

            return b.Any(c => !a.Contains(c)) ? 0 : bDict.Values.Min();
        }
        
        // 8. Integer to a string with fixed width [ 1234, width = 2, result = "34"; 1234, width = 5, result = "01234"; ]
        public static string StringFromIntWithWidth(int num, int width)
        {
            var sub = width - num.ToString().Length;
            var zero = string.Empty;
            
            if(sub > 0)
                zero = new string('0', sub);

            var result = zero + num;
            return result;
        }
        
        // 9. Get one string from another
        public static bool OneStringFromAnother(string a, string b)
        {
            var resStr = new StringBuilder();
            var newResIndex = 0;
            
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] == b[newResIndex])
                {
                    resStr.Append(a[i]);
                    newResIndex++;
                }
            }

            return resStr.ToString() == b;
        }
        
        // 10. Return array of longest strings
        public static List<string> LongestStrings(List<string> arr)
        {
            if (arr == null || !arr.Any())
                return new List<string>();
            
            var longestStrLength = arr.OrderByDescending(el => el.Length).FirstOrDefault().Length;
            var newList = arr.Where(str => str.Length == longestStrLength).ToList();

            return newList;
        }
        
        // 11. Get string and return new string with chars changed to number of chars
        public static string StringRle(string str)
        {
            var sb = new StringBuilder();
            var counter = 1;

            for (var i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    counter++;

                    if (i == str.Length - 1)
                    {
                        sb.Append(str[i]);
                        sb.Append(counter);
                    }
                }
                else
                {
                    sb.Append(str[i - 1]);
                    sb.Append(counter);
                    
                    counter = 1;

                    if (i == str.Length - 1)
                    {
                        sb.Append(str[i]);
                        sb.Append(counter);
                    }
                }
                    
            }

            return sb.ToString();
        }
        
        // 12. Change words side in string
        public static string ChangeWords(string str)
        {
            return string.Join(" ", str.Split(' ')
                .OrderBy(s => s)
                .Reverse());
        }
        
        // 13. Fibonachi after given number
        public static void FinonachiAfter(int position, int num)
        {
            var strWithNums = new StringBuilder();

            for (var i = 0; i <= num; i++)
            {
                strWithNums.Append(FibonachiTwo(i));
                if(i != num)
                    strWithNums.Append('-');
            }

            var fullList = strWithNums.ToString().Split('-').ToList();
            var result = fullList.GetRange(position, num - position);
            
            Console.WriteLine($"For position {position} and number {num} result is: {string.Join(" ", result)}");
        }
        
        private static int FibonachiTwo(int num)
        {
            if (num <= 1)
                return num;
            return FibonachiTwo(num - 1) + FibonachiTwo(num - 2);
        }
        
        // 14. Longest palindrome substring
        public static void PalindromeSubstring(string str)
        {
            var subsets = new List<string>();
            for (var i = 0; i < str.Length - 1; i++)
            {
                for (var j = i + 1; j <= str.Length; j++)
                {
                    if (j - i > 1 && str[j - 1] == str[i])
                    {
                        var currentSubset = str.Substring(i, j - i);
                        if (IsPalindromeGlobal(currentSubset))
                        {
                            subsets.Add(currentSubset);
                        }
                    }
                }
            }

            Console.Write("\nAll palindromes: ");
            foreach (var pal in subsets)
            {
                Console.Write($"{pal} ");
            }
        }
        
        private static bool IsPalindromeGlobal(string input)
        {
            return !input.Where((t, i) => t != input[input.Length - 1 - i]).Any();
        }
        
        // 15. Remove duplicates recursive
        public static void RemoveAdjDuplicates(string str)
        {
            var i = 0;
            var deletedChar = '#';
            var newArr = new StringBuilder(str);
            RemoveAdjDuplicates(newArr, i, deletedChar);
        }

        private static void RemoveAdjDuplicates(StringBuilder str, int i, char deletedChar)
        {
            if (i == str.Length - 1 || i == str.Length)
            {
                Console.Write($"\nFinal string is {str}");
            }
            else if (str[i] == str[i + 1])
            {
                if (i != str.Length && i != str.Length - 1)
                    deletedChar = str[i];
                str.Remove(i, 2);
                RemoveAdjDuplicates(str, i, deletedChar);
            }
            else if (str[i] == deletedChar)
            {
                str.Remove(i, 1);
                deletedChar = '#';
                RemoveAdjDuplicates(str, i, deletedChar);
            }
            else
            {
                RemoveAdjDuplicates(str, i + 1, deletedChar);
            }

        }
    }
}