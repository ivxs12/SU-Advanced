using System;
using System.Collections.Generic;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int[]> arrays = new List<int[]>(n);
            int value = 0;

            for (int i = 0; i < n; i++)
            {
                int[] arr = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        value = 1;
                        arr[j] = value;
                    }
                    else
                    {
                        value = value * (i - j + 1) / j;
                        arr[j] = value;
                    }
                }
                arrays.Add(arr);
            }
            foreach (int[] item in arrays)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
