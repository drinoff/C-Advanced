using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Pesho";
            person.Age = 20;

            Person person2 = new Person
            {
                Name = "Gosho",
                Age = 18
            };
        }
    }
}
