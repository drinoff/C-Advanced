using System;
using System.Collections.Generic;
using System.Text;

namespace tuple
{
    class Tuple<T1,T2>
    {
        public T1 Value { get; set; }
        public T2 SecondValue { get; set; }

        public Tuple(T1 value, T2 secondValue)
        {
            Value = value;
            SecondValue = secondValue;
        }
        public override string ToString()
        {
            return $"{Value} -> {SecondValue}";
        }
    }
}
