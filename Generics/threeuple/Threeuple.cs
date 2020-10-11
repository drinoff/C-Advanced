using System;
using System.Collections.Generic;
using System.Text;

namespace threeuple
{
    class Threeuple<T1,T2,T3>
    {
        public T1 Value { get; set; }
        public T2 SecondValue { get; set; }
        public T3 ThirdValue { get; set; }

        public Threeuple(T1 value, T2 secondValue,T3 thirdValue)
        {
            Value = value;
            SecondValue = secondValue;
            ThirdValue = thirdValue;
        }
        public override string ToString()
        {
            return $"{Value} -> {SecondValue} -> {ThirdValue}";
        }
    }
}
