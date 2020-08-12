using System;
using System.Collections.Generic;
using System.Linq;

namespace traficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var canPass = int.Parse(Console.ReadLine());
            var myQueue = new Queue<string>();
            var input = Console.ReadLine();
            var passedCounter = 0;
            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < canPass; i++)
                    {
                        if(myQueue.Any())
                        {
                            Console.WriteLine($"{myQueue.Dequeue()} passed!");
                            passedCounter++;
                        }
                    }
                }
                else
                {
                    myQueue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{passedCounter} cars passed the crossroads.");

        }
    }
}
