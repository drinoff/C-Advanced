using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            var circle = new Queue<string>();
            FillQueue(numberOfPumps, circle);

            int totalFuel = 0;

            for (int i = 0; i < numberOfPumps; i++)
            {
                string currentInfo = circle.Dequeue();
                int[] info = currentInfo.Split().Select(int.Parse).ToArray();
                int fuel = info[0];
                int distance = info[1];
                totalFuel += fuel;
                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }

                else
                {
                    totalFuel = 0;

                    i = -1;
                }
                circle.Enqueue(currentInfo);
            }

            string[] infoForStartPump = circle.Peek().Split().ToArray();
            int index = int.Parse(infoForStartPump[2]);
            Console.WriteLine(index);
        }

        private static void FillQueue(int numberOfPumps, Queue<string> circle)
        {
            for (int i = 0; i < numberOfPumps; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                circle.Enqueue(input);
            }
        }
    }
}
