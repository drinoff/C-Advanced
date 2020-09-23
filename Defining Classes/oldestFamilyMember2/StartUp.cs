using DefiningClasses;
using System;

namespace oldestFamilyMember2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var personsCount = int.Parse(Console.ReadLine());
            var familyList = new Family();
            

            for (int i = 0; i < personsCount; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);
                var person = new Person(name, age);

                familyList.AddMember(person);
            }

            var oldest = familyList.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
