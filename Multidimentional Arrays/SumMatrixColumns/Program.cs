using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            int[] sumOfColumns = new int[size[1]];

            for (int i = 0; i < size[0]; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int z = 0; z < size[1]; z++)
                {
                    matrix[i, z] = row[z];
                }
            }

            for (int i = 0; i < size[1]; i++)
            {
                for (int z = 0; z < size[0]; z++)
                {
                    sumOfColumns[i] += matrix[z, i];
                }
            }

            foreach (int item in sumOfColumns)
            {
                Console.WriteLine(item);
            }
        }
    }
}
