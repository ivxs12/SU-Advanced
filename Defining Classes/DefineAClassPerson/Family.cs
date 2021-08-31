using System.Collections.Generic;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> People { get; set; }
        
        public void AddMember(Person person)
        {
            this.People.Add(person);
        }
        public Person GetOldestMember()
        {
            int current = 0;
            foreach (Person person in People)
            {
                if (person.Age > current)
                {
                    current = person.Age;
                }
            }
            return People.Find(x => x.Age == current);
        }
    }
}
