using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] sets = Console.ReadLine().Split().Selesct(int.Parse).ToArray();
			HashSet<int> nums = new HashSet<int>(sets[0]);
			HashSet<int> nums2 = new HashSet<int>(sets[1]);

			for (int i = 0; i < sets[0]; i++)
			{
				int num = int.Parse(Console.ReadLine());
				nums.Add(num);
			}
			for (int i = 0; i < sets[1]; i++)
			{
				int num = int.Parse(Console.ReadLine());
				nums2.Add(num);
			}
			nums.IntersectWith(nums2);
			Console.WriteLine(string.Join(" ", nums));
		}
    }
}
