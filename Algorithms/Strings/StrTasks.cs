using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Arrays.Strings
{
    public static class StrTasks
    {
        // 1. Remove duplicate chars from string
        public static string RemoveDuplicateChars(string currString)
        {
            var temp = new StringBuilder();
            var result = new StringBuilder();
            
            foreach (var elem in currString)
            {
                if (!temp.ToString().Contains(elem))
                {
                    temp.Append(elem);
                    result.Append(elem);
                }
            }

            return result.ToString();
        }
        
        // 2. Check if two Strings are anagrams of each other
        
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
    }
}