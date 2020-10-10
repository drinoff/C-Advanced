using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace genericCountMethodStrings
{
    public class Box<T> where T : IComparable
    {
        public List<T> List = new List<T>();
        public Box(List<T> list)
        {
            List = list;
        }
        
        public int ComparerByValue(List<T> list, T value)
        {
            var counter = 0;
            foreach (var element in list)
            {
                var result = element.CompareTo(value);
                if (result > 0)
                {
                    counter++;                    
                }
            }
            return counter;
        }

    }
}
