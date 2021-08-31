using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string, int, bool> isValid = (str, num) => str.ToCharArray().Select(ch => (int)ch).Sum() >= num;
            Func<string[], int, Func<string, int, bool>, string> firstValid = (arr, num, func) => arr.FirstOrDefault(str => func(str, num));
            var result = firstValid(names, sum, isValid);
            Console.WriteLine(result);
        }
    }
}
