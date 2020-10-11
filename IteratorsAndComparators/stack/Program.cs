using System;
using System.Linq;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new MyStack<string>();
            var input = Console.ReadLine();
            while (input != "END")
            {
                var line = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = line[0];
                switch (command)
                {
                    case "Push":
                        foreach (var item in line.Skip(1))
                        {
                            myStack.Push(item);
                        }
                        break;
                    case "Pop":
                        try
                        {
                            myStack.Pop();
                        }
                        catch (InvalidOperationException msg)
                        {

                            Console.WriteLine(msg.Message); ;
                        }
                        
                        break;
                }
                input = Console.ReadLine();
            }
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    foreach (var item in myStack)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (InvalidOperationException msg)
            {

                Console.WriteLine(msg.Message); ;
            }
            
        }
    }
}
