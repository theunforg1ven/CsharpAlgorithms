using System;

namespace Arrays.FactorialFib
{
	public static class RecursiveTasks
	{
        // Написать программу для вывода n первых членов арифметической прогрессии 1, 2, 3… 
        // с использованием рекурсивного метода.
        public static int T1Progression(int num)
        {
            if (num == 0)
                return 1;
            else
                return T1Progression(num - 1) + 1;
        }

        // Напишите программу для получения суммы n первых членов арифметической прогрессии. 
        // Разность прогрессии d задается в качестве параметра.
        public static int T2ProgressionSum(int num, int d)
        {
            if (num == 0)
                return d;
            else
                return T2ProgressionSum(num - 1, d) + d;
        }

        // Напишите программу для поиска индекса максимального элемента массива 
        // с использованием рекурсии.
        public static int T4IndexOfMax(int[] arr, int len)
        {
            if (len == 0)
                return len;
            else
			{
                var index = T4IndexOfMax(arr, len - 1);
				if (arr[len] > arr[index])
				{
                    return len;
				}
                else
				{
                    return index;
				}

            } 
        }

        // Напишите программу для переворота строки с использованием рекурсии. 
        // Строка “abс” переворачивается в “cba”.
        public static void T3ReverseStr(char[] str)
        {
            int i = 0;
            int j = str.Length - 1;
            T3ReverseStr(str, i, j);
        }

        private static void T3ReverseStr(char[] str, int i, int j)
        {
            if (i >= j)
            {
                Console.WriteLine(str);
            }
            else
            {
                Swap(ref str[i], ref str[j]);
                T3ReverseStr(str, i + 1, j - 1);
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
