using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		Queue<int> stack = new Queue<int>();

		int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
		int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

		for (int i = 0; i < arr[0]; i++)
		{
			stack.Enqueue(arr2[i]);
		}
		for (int i = 0; i < arr[1]; i++)
		{
			stack.Dequeue();
		}

		if (stack.Contains(arr[2]))
		{
			Console.WriteLine("true");
		}
		else
		{
			if (stack.Count <= 0)
			{
				Console.WriteLine("0");
			}
			else
			{
				Console.WriteLine(stack.Min());
			}
		}
	}
}
