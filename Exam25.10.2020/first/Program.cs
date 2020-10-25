using System;
using System.Collections.Generic;
using System.Linq;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToList());
            var threads = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            var taskToKill = int.Parse(Console.ReadLine());

            while (true)
            {
                var currentTask = tasks.Peek();
                var currentThread = threads.Peek();
                if(currentTask == taskToKill)
                {
                    Console.WriteLine($"Thread with value {threads.Peek()} killed task {tasks.Peek()}");                    
                    Console.WriteLine(string.Join(" ",threads));
                    break;
                }
                else
                {
                    if(currentTask<=currentThread)
                    {
                        tasks.Pop();
                        threads.Dequeue();
                    }
                    else
                    {
                        threads.Dequeue();
                    }
                }
            }
        }
    }
}
