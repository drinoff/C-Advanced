using System;
using System.Collections.Generic;

namespace uniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var userCounts = int.Parse(Console.ReadLine());
            var userSet = new HashSet<string>();

            for (int i = 0; i < userCounts; i++)
            {
                var userName = Console.ReadLine();
                userSet.Add(userName);
            }
            foreach (var user in userSet)
            {
                Console.WriteLine(user);
            }
        }
    }
}
