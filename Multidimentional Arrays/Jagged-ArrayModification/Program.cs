using System;
using System.Linq;

namespace Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int z = 0; z < n; z++)
                {
                    matrix[i, z] = input[z];
                }
            }
            string[] command = Console.ReadLine().Split();
            while(command[0] != "END")
            {
                switch (command[0])
                {
                    case "Add":
                        if (!(n - 1 < Convert.ToInt32(command[1]) || n - 1 < Convert.ToInt32(command[2]) || Convert.ToInt32(command[1]) < 0 || Convert.ToInt32(command[2]) < 0))
                        {
                            matrix[Convert.ToInt32(command[1]), Convert.ToInt32(command[2])] += Convert.ToInt32(command[3]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    case "Subtract":
                        if (!(n - 1 < Convert.ToInt32(command[1]) || n - 1 < Convert.ToInt32(command[2]) || Convert.ToInt32(command[1]) < 0 || Convert.ToInt32(command[2]) < 0))
                        {
                            matrix[Convert.ToInt32(command[1]), Convert.ToInt32(command[2])] -= Convert.ToInt32(command[3]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }
            for (int i = 0; i < n; i++)
            {
                for (int z = 0; z < n; z++)
                {
                    Console.Write(matrix[i, z] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
