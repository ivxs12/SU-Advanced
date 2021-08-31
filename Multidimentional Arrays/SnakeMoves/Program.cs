using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[n[0], n[1]];
            string snake = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < n[0]; i++)
            {
                if (!(i % 2 == 0))
                {
                    for (int z = n[1] - 1; z >= 0; z--)
                    {
                        if (count > snake.Length - 1)
                        {
                            count = 0;
                        }
                        matrix[i, z] = snake[count];
                        count++;
                    }
                }
                else
                {
                    for (int z = 0; z < n[1]; z++)
                    {
                        if (count > snake.Length - 1)
                        {
                            count = 0;
                        }
                        matrix[i, z] = snake[count];
                        count++;
                    }
                }
            }

            for (int i = 0; i < n[0]; i++)
            {
                for (int z = 0; z < n[1]; z++)
                {
                    Console.Write(matrix[i, z]);
                }
                Console.WriteLine();
            }
        }
    }
}
