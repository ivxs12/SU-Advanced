using System;
using System.Linq;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int z = 0; z < n; z++)
                {
                    matrix[i, z] = input[z];
                }
            }

            char find = char.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int z = 0; z < n; z++)
                {
                    if (find == matrix[i, z])
                    {
                        Console.WriteLine($"({i}, {z})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{find} does not occur in the matrix");
        }
    }
}
