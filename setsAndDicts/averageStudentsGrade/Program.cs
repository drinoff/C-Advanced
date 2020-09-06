using System;
using System.Collections.Generic;
using System.Linq;

namespace averageStudentsGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<double>>();
            for (int i = 0; i < count; i++)
            {
                var input = InputParser();
                var name = input[0];
                var grade = double.Parse(input[1]);

                if(!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<double>());
                }
                    dict[name].Add(grade);
            }
            foreach (var student in dict)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ",student.Value)} (avg: {student.Value.Average():f2})");
            }

        }
        public static string[] InputParser()
        {
            return Console.ReadLine().Split();
        }
        
    }
}
