using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[n[0], n[1]];

            for (int i = 0; i < n[0]; i++)
            {
                string[] row = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int z = 0; z < n[1]; z++)
                {
                    matrix[i, z] = row[z];
                }
            }

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "END")
            {
                if (command[0] == "swap" && Convert.ToInt32(command[1]) < n[0] && Convert.ToInt32(command[3]) < n[0] && Convert.ToInt32(command[2]) < n[1] && Convert.ToInt32(command[4]) < n[1])
                {
                    string first = matrix[Convert.ToInt32(command[1]), Convert.ToInt32(command[2])];
                    string second = matrix[Convert.ToInt32(command[3]), Convert.ToInt32(command[4])];

                    matrix[Convert.ToInt32(command[1]), Convert.ToInt32(command[2])] = second;
                    matrix[Convert.ToInt32(command[3]), Convert.ToInt32(command[4])] = first;

                    for (int i = 0; i < n[0]; i++)
                    {
                        for (int z = 0; z < n[1]; z++)
                        {
                            Console.Write(matrix[i, z] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }
    }
}
