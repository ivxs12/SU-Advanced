using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[n[0], n[1]];
            int count = 0;

            for (int i = 0; i < n[0]; i++)
            {
                char[] row = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int z = 0; z < n[1]; z++)
                {
                    matrix[i, z] = row[z];
                }
            }


            for (int i = 0; i < n[0] - 1; i++)
            {
                for (int z = 0; z < n[1] - 1; z++)
                {
                    if (matrix[i, z] == matrix[i + 1, z] && matrix[i, z] == matrix[i, z + 1] && matrix[i, z] == matrix[i + 1, z + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
