using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> min = (x) => x.Min();
            Console.WriteLine(min(Console.ReadLine().Split().Select(int.Parse).ToArray()));
        }
    }
}
