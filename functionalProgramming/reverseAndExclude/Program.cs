using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace reverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .Reverse()
                                 .ToArray();

            var n = int.Parse(Console.ReadLine());

            Func<int,bool> command = x =>  x % n != 0;
            var numbers2 = numbers.Where(command);
                                 
            Console.WriteLine(string.Join(" ",numbers2));
        }
    }
}
