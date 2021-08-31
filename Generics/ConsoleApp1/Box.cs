using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericBoxOfString
{
    class Box<T> : IComparable<T> where T : IComparable
    {
        public List<T> Elements { get; set; } = new List<T>();
        public T Value { get; set; }
        public Box()
        {
            
        }
        public int CompareTo(T other) => this.Value.CompareTo(other);
        public void Add(T value)
        {
            Elements.Add(value);
        }

        public void Swap(int first, int second)
        {
            T firstElement = Elements[first];
            T secondElement = Elements[second];

            Elements[first] = secondElement;
            Elements[second] = firstElement;
        }
        public int Count<T>(T value) where T : IComparable => this.Elements.Count(word => word.CompareTo(value) > 0);

        public void Print()
        {
            Elements.ForEach(x => Console.WriteLine($"{typeof(T)}: {x}"));
        }


    }

}
