using System;
using System.Collections.Generic;
using System.Linq;

namespace filterByAge
{
    class Program
    {
        public class Person
        {
            public Person()
            {
                this.Name = Name;
                this.Age = Age;
            }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            List<Person> ppl = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                var personInfo = Console.ReadLine().Split(", ");
                var person = new Person();
                person.Name = personInfo[0];
                person.Age = int.Parse(personInfo[1]);
                ppl.Add(person);
            }

            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();
            Func<Person, bool> condChecker;

            switch (condition)
            {
                case "younger":
                    condChecker = c => c.Age < age;
                    break;
                default:
                    condChecker = c => c.Age >= age;
                    break;
                

                
            }
            var filteredppl = ppl.Where(condChecker);

            foreach (var person in filteredppl)
            {
                
                switch (format)
                {
                    case "name":
                        
                        Console.WriteLine(person.Name);
                        break;
                    case "age":
                        
                        Console.WriteLine(person.Age);
                        break;
                    default:
                        var output = format.Replace("name", person.Name).Replace("age", person.Age.ToString()).Replace(" "," - ");
                        Console.WriteLine(output);
                        break;
                }
                
            }
        }

    }
}
