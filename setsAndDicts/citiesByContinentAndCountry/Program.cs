using System;
using System.Collections.Generic;

namespace citiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split();
                var continent = input[0];
                var country = input[1];
                var city = input[2];
                if (!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent].Add(country, new List<string>());
                }


                dict[continent][country].Add(city);

            }
            foreach (var cont in dict)
            {
                Console.WriteLine($"{cont.Key}:");
                foreach (var countr in cont.Value)
                {
                    Console.WriteLine($"{countr.Key} -> {string.Join(", ", countr.Value)}");
                }
            }

        }
    }
}
