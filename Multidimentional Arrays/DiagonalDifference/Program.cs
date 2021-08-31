using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumPrimary = 0;
            int sumSecondary = 0;
            int count = n - 1;

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int z = 0 ; z < n; z++)
                {
                    if (i == z)
                    {
                        sumPrimary += row[z];
                    }
                    if (count == z)
                    {
                        sumSecondary += row[z];
                    }
                    
                }
                count--;
            }
            Console.WriteLine(Math.Abs(sumPrimary - sumSecondary));
        }
    }
}
