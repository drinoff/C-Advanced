using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            var greenLightSec = int.Parse(Console.ReadLine());
            var freeWindowSec = int.Parse(Console.ReadLine());

            var myQueue = new Queue<string>();
            var carParts = new Queue<char>();
            var carsPassed = 0;

            var input = Console.ReadLine();
            while (true)
            {
                if (input == "END")
                {
                    break;
                }
                else
                {
                    switch (input)
                    {
                        case "green":
                            var passTime = greenLightSec + freeWindowSec;
                            while (passTime >= 0)
                            {
                                if (myQueue.Any())
                                {
                                    var car = myQueue.Dequeue().ToCharArray();

                                    for (int i = 0; i < car.Length; i++)
                                    {
                                        carParts.Enqueue(car[i]);
                                    }
                                    while (carParts.Any())
                                    {
                                        var hit = carParts.Dequeue();
                                        passTime--;
                                        if (passTime == 0)
                                        {
                                            Console.WriteLine($"A crash happened!");
                                            Console.WriteLine($"{string.Join("",car)} was hit at {hit}.");
                                            System.Environment.Exit(0);
                                        }
                                    }
                                    carsPassed++;
                                }
                                else
                                {
                                    passTime = greenLightSec + freeWindowSec;
                                    break;
                                }
                            }
                            break;
                        default:
                            myQueue.Enqueue(input);
                            break;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
        }
    }
}
