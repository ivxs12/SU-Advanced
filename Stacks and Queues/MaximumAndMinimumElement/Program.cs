using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		Stack<int> stack = new Stack<int>();


		for (int i = 0; i < n; i++)
		{
			int[] querry = Console.ReadLine().Split().Select(int.Parse).ToArray();
			switch (querry[0])
			{
				case 1:
					stack.Push(querry[1]);
					break;
				case 2:
					stack.Pop();
					break;
				case 3:
					if (stack.Count != 0)
					{
						Console.WriteLine(stack.Max());
					}
					break;
				case 4:
					if (stack.Count != 0)
					{
						Console.WriteLine(stack.Min());
					}
					break;
				default:
					break;
			}
		}
		Console.WriteLine(string.Join(", ", stack));
	}
}
