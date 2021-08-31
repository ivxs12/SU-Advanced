using System;
using System.Linq;

namespace DateModifier
{
    public class DateModifier
    {
        public string FirstDate { get; set; }
        public string SecondDate { get; set; }

        public DateModifier()
        {

        }
        public DateModifier(string firstDate, string secondDate) : this()
        {
            this.FirstDate = firstDate;
            this.SecondDate = secondDate;
        }
        public int CalculateDifference()
        {
            int[] first = this.FirstDate.Split().Select(int.Parse).ToArray();
            int[] second = this.SecondDate.Split().Select(int.Parse).ToArray();
            DateTime date1 = new DateTime(first[0], first[1], first[2]);
            DateTime date2 = new DateTime(second[0], second[1], second[2]);
            return Math.Abs(Convert.ToInt32(date1.Subtract(date2).TotalDays));
        }
    }
}
