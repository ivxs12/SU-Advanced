using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
			string n = Console.ReadLine();
			var elements = new SortedDictionary<char, int>();

			for (int i = 0; i < n.Length; i++)
			{
				if (!elements.ContainsKey(n[i]))
				{
					elements.Add(n[i], 1);
				}
				else
				{
					elements[n[i]] += 1;
				}
			}
			foreach (var element in elements)
			{
				Console.WriteLine(element.Key + ": " + element.Value + " time/s");
			}
		}
    }
}
