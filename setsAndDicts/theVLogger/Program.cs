using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace theVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vLogger = new List<string>();
            var vLogerObjects = new List<Vloger>();
            var input = Console.ReadLine();
            while (!input.Contains("Statistic"))
            {
                var command = input.Split();
                var name = command[0];
                var action = command[1];

                switch (action)
                {
                    case "joined":
                        var vlogger = new Vloger(name);
                        if (!vLogger.Contains(vlogger.Name))
                        {
                            vLogger.Add(vlogger.Name);
                            vLogerObjects.Add(vlogger);
                        }
                        break;
                    case "followed":

                        var vloggerOne = command[0];
                        var vloggerTwo = command[2];

                        if (vLogger.Contains(vloggerOne) && vLogger.Contains(vloggerTwo))
                        {
                            if (vloggerOne != vloggerTwo)
                            {
                                var vlogger1 = vLogerObjects.FirstOrDefault(x => x.Name == vloggerOne);
                                var vlogger2 = vLogerObjects.FirstOrDefault(x => x.Name == vloggerTwo);
                                if (!vlogger2.Followers.Contains(vlogger1))
                                {
                                    vlogger2.AddFollower(vlogger1, vlogger2, vlogger2.Followers, vlogger1.Following);
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            var counter = 2;
            Console.WriteLine($"The V-Logger has a total of {vLogger.Count} vloggers in its logs.");

            var SortedvLoggerObj = vLogerObjects.OrderByDescending(x => x.Followers.Count)
                                                .ThenBy(x => x.Following.Count)
                                                .ToList();

            Console.WriteLine($"1. {SortedvLoggerObj[0].Name} : { SortedvLoggerObj[0].Followers.Count} followers, {SortedvLoggerObj[0].Following.Count} following");
            foreach (var item in SortedvLoggerObj[0].Followers.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"*  {item.Name}");
                
            }
            SortedvLoggerObj.RemoveAt(0);
            foreach (var element in SortedvLoggerObj)
            {
                Console.WriteLine($"{counter}. {element.Name} : {element.Followers.Count} followers, {element.Following.Count} following");
                counter++;
            }

        }
        public class Vloger
        {
            public string Name { get; set; }
            public List<Vloger> Followers = new List<Vloger>();
            public List<Vloger> Following = new List<Vloger>();

            public Vloger(string name)
            {
                this.Name = name;
            }
            public List<Vloger> AddFollower(Vloger vlogger1, Vloger vloger2, List<Vloger> Followers, List<Vloger> Following)
            {

                vloger2.Followers.Add(vlogger1);
                vlogger1.Following.Add(vloger2);

                return Followers;
            }

        }
    }
}
