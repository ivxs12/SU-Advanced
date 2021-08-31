using System;
using System.Linq;

namespace SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            int[,] biggestSquare = new int[2, 2];
            int sum = 0;

            for (int i = 0; i < size[0]; i++)
            {
                int[] row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int z = 0; z < size[1]; z++)
                {
                    matrix[i, z] = row[z];
                }
            }

            for (int i = 0; i < size[0] - 1; i++)
            {
                for (int z = 0; z < size[1] - 1; z++)
                {
                    if (sum < matrix[i, z] + matrix[i + 1, z] + matrix[i + 1, z + 1] + matrix[i, z + 1])
                    {
                        sum = matrix[i, z] + matrix[i + 1, z] + matrix[i + 1, z + 1] + matrix[i, z + 1];
                        biggestSquare[0, 0] = matrix[i, z];
                        biggestSquare[1, 0] = matrix[i + 1, z];
                        biggestSquare[0, 1] = matrix[i, z + 1];
                        biggestSquare[1, 1] = matrix[i + 1, z + 1];
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int z = 0; z < 2; z++)
                {
                    Console.Write(biggestSquare[i, z] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(sum);
        }
    }
}
