using System;
using System.Collections.Generic;
using System.Linq;

namespace clubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxCapacity = int.Parse(Console.ReadLine());
            var line = Console.ReadLine().Split();
            var myStack = new Stack<string>(line);
            var result = -1;
            var halls = new Queue<string>();
            var pax = new Queue<int>();

            var currHallPax = new List<int>();
            var currHall = string.Empty;

            while (result != 0)
            {

                var type = int.TryParse(myStack.Peek(), out result);
                if (type)
                {
                    myStack.Pop();
                }
                else
                {
                    break;
                }

            }
            while (myStack.Any())
            {
                var type = int.TryParse(myStack.Peek(), out result);
                if (type)
                {
                    pax.Enqueue(int.Parse(myStack.Pop()));
                }
                else
                {
                    halls.Enqueue(myStack.Pop());
                }
            }
            while (true)
            {


                while (halls.Any())
                {

                    if (currHallPax.Sum() + pax.Peek() < maxCapacity)
                    {
                        currHallPax.Add(pax.Dequeue());

                    }
                    else
                    {
                        currHall = halls.Dequeue();
                        Console.WriteLine($"{currHall} -> {string.Join(", ", currHallPax)}");
                        currHallPax.Clear();
                        break;
                    }


                }
            }
        }
    }
}
