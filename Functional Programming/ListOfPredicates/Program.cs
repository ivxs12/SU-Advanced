using System;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int, bool> divisible = (x, y) =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (y % x[i] != 0)
                    {
                        return false;
                    }
                }
                return true;
            };
            Enumerable.Range(1, num).Where(x => divisible(dividers, x) == true).ToList().ForEach(x => Console.Write(x + " "));
        }
    }    
}
