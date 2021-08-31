using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {      
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            Predicate<int> divide = x => x % num == 0;
            arr.Where(x => divide(x) != true).Reverse().ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}
