using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>(n);

            for (int i = 0; i < n; i++)
            {
                string[] element = Console.ReadLine().Split().ToArray();
                for (int z = 0; z < element.Length; z++)
                {
                    elements.Add(element[z]);
                }
            }
            elements = elements.Distinct().ToHashSet();
            elements = elements.OrderBy(x => x).ToHashSet();
            foreach (string element in elements)
            {
                Console.Write(element + " ");
            }
        }
    }
}
