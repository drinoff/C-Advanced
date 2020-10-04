using System;
using System.Linq;

namespace actionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> name = Console.WriteLine;
            Console.ReadLine().Split().ToList().ForEach(name);
            

            
        }
    }
}
