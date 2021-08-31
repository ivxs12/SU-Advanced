using System;
using System.Linq;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> name = (x) => Console.WriteLine(x);
            Console.ReadLine().Split().ToList().ForEach(name);     
        }
    }
}
