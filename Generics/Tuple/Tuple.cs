using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    class Tuple<T1, T2, T3>
    {
        public T1 FirstValue { get; set; }
        public T2 SecondValue { get; set; }
        public T3 ThirdValue { get; set; }

        public Tuple(T1 first, T2 second, T3 third)
        {
            this.FirstValue = first;
            this.SecondValue = second;
            this.ThirdValue = third;
        }

    }
}
