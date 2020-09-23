using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{

    public class Person
    {
        public Person(string name, int age)            
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
