using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace dictTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var extensionCount = new Dictionary<string, int>();
            Console.WriteLine("Please input a Relative or Absulute Path:");
            var path = Console.ReadLine();
            var files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                var extensionSplit = files[i].Split(".");
                var extension = extensionSplit[extensionSplit.Length - 1];
                if (!extensionCount.ContainsKey(extension))
                {
                    extensionCount.Add(extension, 0);
                }
                extensionCount[extension]++;
            }

            using (var sw = new StreamWriter("report.txt"))
            {
                foreach (var extension in extensionCount.OrderByDescending(x => x.Value)
                                                        .ThenBy(x => x.Key))
                    { 
                            sw.WriteLine($".{extension.Key}", FileMode.Append);
                    foreach (var item in files.Where(x => x.Contains(extension.Key)))
                    {
                        sw.WriteLine($"--{item.Replace(".\\", "")}", FileMode.Append);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, files));
        }
    }
}
