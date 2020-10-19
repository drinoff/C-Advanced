using System;
using System.Collections.Generic;
using System.Linq;

namespace bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            var bombs = new Dictionary<string, int>
            {
                {"Datura Bombs" , 0},
                {"Cherry Bombs", 0},
                {"Smoke Decoy Bombs", 0}
            };
            var datura = 40;
            var cherry = 60;
            var smoke = 120;
            var bombEffect = new Queue<int>(InputParser());
            var bombCasing = new Stack<int>(InputParser());
            var hasSuccess = false;


            while (bombCasing.Any() && bombEffect.Any())
            {
                var currentBombEffect = bombEffect.Dequeue();  // might have a problem here!!!
                var currentBombCasing = bombCasing.Pop();
                while (true)
                {
                var currentBomb = currentBombEffect + currentBombCasing;
                    if (IsDatura(currentBomb,datura))
                    { 
                        bombs["Datura Bombs"]++;
                        break;
                    }
                    else if (IsCherry(currentBomb,cherry))
                    {
                        bombs["Cherry Bombs"]++;
                        break;
                    }
                    else if (IsSmokeDecoy(currentBomb,smoke))
                    {
                        bombs["Smoke Decoy Bombs"]++;
                        break;
                    }
                    else
                    {
                        currentBombCasing -= 5;
                    }   
                }
                if(CheckBombs(bombs))
                {
                    hasSuccess = true;
                    break;
                }
            }
            Print(hasSuccess, bombEffect, bombCasing, bombs);

        }
        public static int[] InputParser() => Console.ReadLine()
                                                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(int.Parse)
                                                    .ToArray();
        public static bool CheckBombs(Dictionary<string, int> bombs) => bombs.Values.All(x => x >= 3);

        public static bool IsDatura(int currentBomb, int datura) => currentBomb == datura;
        public static bool IsCherry(int currentBomb, int cherry) => currentBomb == cherry;
        public static bool IsSmokeDecoy(int currentBomb, int smoke) => currentBomb == smoke;

        public static void Print(bool hasSuccess,Queue<int> bombEffect,Stack<int> bombCasing,Dictionary<string,int> bombs)
        {
            if (hasSuccess)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (!bombEffect.Any())
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffect)}");
            }
            if (!bombCasing.Any())
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }
            foreach (var bomb in bombs.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }





    }
}
