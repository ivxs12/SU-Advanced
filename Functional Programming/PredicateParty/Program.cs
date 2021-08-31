using System;
using System.Linq;
using System.Collections.Generic;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "Party!")
            {
                if (command[0] == "Remove")
                {
                    switch (command[1])
                    {
                        case "EndsWith":
                            names = Remove(names, command[2], (name, letter) => name.EndsWith(letter));
                            break;
                        case "StartsWith":
                            names = Remove(names, command[2], (name, letter) => name.StartsWith(letter));
                            break;
                        case "Length":
                            names = Remove(names, command[2], (name, letter) => (name.Length == Convert.ToInt32(letter)));
                            break;
                    }
                }
                else
                {
                    switch (command[1])
                    {
                        case "EndsWith":
                            names = Double(names, command[2], (name, letter) => name.EndsWith(letter));
                            break;
                        case "StartsWith":
                            names = Double(names, command[2], (name, letter) => name.StartsWith(letter));
                            break;
                        case "Length":
                            names = Double(names, command[2], (name, letter) => (name.Length == Convert.ToInt32(letter)));
                            break;
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            if (names.Count != 0)
            {
                Console.WriteLine(string.Join(", ", names.OrderBy(x => x)) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            
        }
        static List<string> Remove(List<string> names, string comm, Func<string, string, bool> func) => names.Where(name => func(name, comm) == false).ToList();
        static List<string> Double(List<string> names, string comm, Func<string, string, bool> func) => names.Where(name => func(name, comm) == true).ToList().Concat(names).ToList();
    }
}
