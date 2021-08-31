using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string comm = Console.ReadLine();
            while (comm != "end")
            {
                switch (comm)
                {
                    case "add":
                        nums = ForEach(nums, number => number + 1);
                        break;
                    case "subtract":
                        nums = ForEach(nums, number => number - 1);
                        break;
                    case "multiply":
                        nums = ForEach(nums, number => number * 2);
                        break;
                    case "print":
                        print(nums);
                        break;
                    default:
                        break;
                }
                comm = Console.ReadLine();
            }
        }
        public static int[] ForEach(int[] nums, Func<int, int> func) => nums.Select(x => func(x)).ToArray();
    }
}
