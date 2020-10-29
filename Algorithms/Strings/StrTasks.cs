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

            return b.Any(c => !a.Contains(c)) 
                                ? 0 : bDict.Values.Min();
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
                        if (counter > 1)
                            sb.Append(counter);
                    }
                }
                else
                {
                    if (i >= 1)
                        sb.Append(str[i - 1]);
                    

                    if (i == str.Length - 1)
                        sb.Append(str[i]);
                    

                    if (counter > 1)
                        sb.Append(counter);
                    
                    counter = 1;
                }
                    
            }

            return sb.ToString();
        }
    }
}