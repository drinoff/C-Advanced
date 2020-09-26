using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace opinionPoll
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var personsCount = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < personsCount; i++)
            {
                var personInfo = InputParser();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);
                var person = new Person(name, age);
                persons.Add(person);
            }
            
            
            foreach (var person in persons.OrderBy(x => x.Name).Where(x => x.Age > 30))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
        public static string[] InputParser()

        {
            return Console.ReadLine().Split();
        }
    }
}
