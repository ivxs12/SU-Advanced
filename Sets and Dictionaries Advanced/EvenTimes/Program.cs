using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			Dictionary<int, int> elements = new Dictionary<int, int>(n);

			for (int i = 0; i < n; i++)
			{
				int element = int.Parse(Console.ReadLine());
				if (!elements.ContainsKey(element))
				{
					elements.Add(element, 0);
				}
				else
				{
					elements[element] += 1;
				}
			}
			foreach (var element in elements)
			{
				if (element.Value % 2 != 0)
				{
					Console.WriteLine(element.Key);
				}
			}
		}
    }
}
