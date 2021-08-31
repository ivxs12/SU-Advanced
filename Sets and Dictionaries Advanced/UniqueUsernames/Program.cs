using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			List<string> names = new List<string>();

			for (int i = 0; i < n; i++)
			{
				string name = Console.ReadLine();
				if (!names.Contains(name))
				{
					names.Add(name);
				}
			}
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}
		}
    }
}
