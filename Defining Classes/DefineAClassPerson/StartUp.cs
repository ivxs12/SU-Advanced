using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person person = new Person(input[0], Convert.ToInt32(input[1]));
                people.Add(person);
            }
            people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList().ForEach(x => Console.WriteLine(x.Name + " - " + x.Age));

        }
    }
}
