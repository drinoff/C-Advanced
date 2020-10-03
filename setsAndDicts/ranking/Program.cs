using System;
using System.Collections.Generic;
using System.Linq;

namespace ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contest = new Dictionary<string, string>();
            var userContests = new Dictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();
            while (input != "end of contests")
            {
                var cotestInfo = input.Split(":");
                var contenstName = cotestInfo[0];
                var contestPass = cotestInfo[1];
                if (!contest.ContainsKey(contenstName))
                {
                    contest.Add(contenstName, contestPass);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "end of contests")
            {
                var userInfo = input.Split("=>");
                var userContest = userInfo[0];
                var password = userInfo[1];
                var username = userInfo[2];
                var points = int.Parse(userInfo[3]);
                if (contest.ContainsKey(userContest) && contest[userContest] == password)
                {
                    if (!userContests.ContainsKey(username))
                    {
                        userContests.Add(username, new Dictionary<string, int>());
                        userContests[username].Add(userContest, points);
                    }
                    if (userContests[username][userContest] <= points)
                    {
                        userContests[username][userContest] = points;
                    }

                }
                input = Console.ReadLine();
            }

            var bestUser = userContests.OrderByDescending(x => x.Value.Sum(x => x.Value)).Take(1).ToList();
            
            Console.WriteLine($"Best candidate is {bestUser[0].Key} with total {bestUser[0].Value.Sum(x=>x.Value)} points.");

        }
    }
}
