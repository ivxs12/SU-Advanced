using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkiRental
{
    class SkiRental
    {
        private int count = 0;
        public List<Ski> Skis { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public SkiRental(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Skis = new List<Ski>(capacity);
        }
        public int Count
        {
            get => this.count;
        }
        public void Add(Ski ski)
        {
            if (count < Capacity)
            {
                Skis.Add(ski);
                count++;
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (Skis.Exists(x => x.Model == model && x.Manufacturer == manufacturer))
            {
                Skis.Where(x => x.Manufacturer != manufacturer && x.Model != model).ToList();
                count--;
                return true;
            }
            else
            {
                return false;
            }          
        }
        public Ski GetNewestSki()
        {
            if (count != 0)
            {
                return Skis.OrderByDescending(x => x.Year).First();
            }
            else
            {
                return null;
            }           
        }
        public Ski GetSki(string manufacturer, string model)
        {
            if (Skis.Exists(x => x.Manufacturer == manufacturer && x.Model == model))
            {
                return Skis.Find(x => x.Manufacturer == manufacturer && x.Model == model);
            }
            else
            {
                return null;
            }
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {this.Name}:");
            foreach (Ski ski in Skis)
            {
                sb.AppendLine(ski.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
