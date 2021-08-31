using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		int food = int.Parse(Console.ReadLine());
		int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
		Queue<int> queue = new Queue<int>();


		for (int i = 0; i < orders.Length; i++)
		{
			queue.Enqueue(orders[i]);
		}

		int biggestOrder = queue.Max();

		while (queue.Count != 0)
		{
			if (food < queue.Peek())
			{
				Console.WriteLine(biggestOrder);
				Console.WriteLine("Orders left: " + string.Join(" ", queue));
				return;
			}
			food -= queue.Dequeue();
		}
		Console.WriteLine(biggestOrder);
		Console.WriteLine("Orders complete");
	}
}
