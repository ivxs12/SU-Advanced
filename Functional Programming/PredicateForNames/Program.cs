using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.ReadLine().Split().Where(x => x.Length <= num).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
