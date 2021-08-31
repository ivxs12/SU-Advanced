using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[n[0], n[1]];
            int sum = 0;
            int startIndex = 0;
            int startIndexRow = 0;

            for (int i = 0; i < n[0]; i++)
            {
                int[] row = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int z = 0; z < n[1]; z++)
                {
                    matrix[i, z] = row[z];
                }
            }
            for (int i = 0; i < n[0] - 2; i++)
            {
                for (int z = 0; z < n[1] - 2; z++)
                {
                    if (matrix[i, z] + matrix[i + 1, z] + matrix[i + 2, z] + matrix[i, z + 1] + matrix[i, z + 2] + matrix[i + 1, z + 1] + matrix[i + 2, z + 2] + matrix[i + 2, z + 1] + matrix[i + 1, z + 2] > sum)
                    {
                        sum = matrix[i, z] + matrix[i + 1, z] + matrix[i + 2, z] + matrix[i, z + 1] + matrix[i, z + 2] + matrix[i + 1, z + 1] + matrix[i + 2, z + 2] + matrix[i + 2, z + 1] + matrix[i + 1, z + 2];
                        startIndex = i;
                        startIndexRow = z;
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            for (int i = startIndex; i < startIndex + 3; i++)
            {     
                for (int z = startIndexRow; z < startIndexRow + 3; z++)
                {
                    Console.Write(matrix[i, z] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
