using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int diagonal = 0;

            for (int i = 0; i < size; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int z = 0; z < size; z++)
                {
                    if (i == z)
                    {
                        diagonal += row[z];
                    }
                }
            }

            Console.WriteLine(diagonal);
        }
    }
}
