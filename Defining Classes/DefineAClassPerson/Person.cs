namespace DefiningClasses
{
    public class Person
    {
        private int age; 
        public string Name { get; set; }
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public Person(int age)
        {
            this.Name = "No name";
            this.Age = age;
        }
        public Person(string name, int age) 
            : this(age)
        {
            this.Name = name;
        }
        public int Age
        {
            get => this.age;
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine($"Can't be below 0");
                }
                else
                {
                    this.age = value;
                }
            }
        }
    }
}
