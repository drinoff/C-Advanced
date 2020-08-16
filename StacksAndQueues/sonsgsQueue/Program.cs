using System;
using System.Collections.Generic;
using System.Linq;

namespace sonsgsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ");
            var myQueue = new Queue<string>(songs);
            var input = Console.ReadLine();
            while (myQueue.Any())
            {
                var command = input.Split();
                var action = command[0];
                switch (action)
                {
                    case "Play":
                        myQueue.Dequeue();
                        break;
                    case "Add":
                        var song = input.Remove(0, 4);
                        if(!myQueue.Contains(song))
                        {
                            myQueue.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }    
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",myQueue));
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
