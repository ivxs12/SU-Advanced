using System;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> even = x => x % 2 == 0;
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string comm = Console.ReadLine();
            Enumerable.Range(range[0], range[1] - range[0] + 1).Where(x => comm == "even" ? even(x) : !even(x)).ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}
