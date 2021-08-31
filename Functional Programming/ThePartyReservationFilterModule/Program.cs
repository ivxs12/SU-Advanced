using System;
using System.Linq;
using System.Collections.Generic;

namespace ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            HashSet<string> filters = new HashSet<string>();
            string[] command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "Print")
            {
                if (command[0] == "Add filter")
                {
                    filters.Add(command[1] + ";" + command[2]);
                }
                else if (command[0] == "Remove filter")
                {
                    filters.Remove(command[1] + ";" + command[2]);
                }
                command = Console.ReadLine().Split(";").ToArray();
            }
            foreach (string item in filters)
            {
                string[] comm = item.Split(";");
                switch (comm[0])
                {
                    case "Ends with":
                        names = Remove(names, comm[1], (name, letter) => name.EndsWith(letter));
                        break;
                    case "Starts with":
                        names = Remove(names, comm[1], (name, letter) => name.StartsWith(letter));
                        break;
                    case "Length":
                        names = Remove(names, comm[1], (name, letter) => (name.Length == Convert.ToInt32(letter)));
                        break;
                    case "Contains":
                        names = Remove(names, comm[1], (name, letter) => name.Contains(letter));
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", names));
        }
        static List<string> Remove(List<string> names, string comm, Func<string, string, bool> func) => names.Where(name => func(name, comm) == false).ToList();
    }
}
