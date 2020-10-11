using System;

namespace threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var value = input[0] + " " + input[1];
            var secondValue = input[2];
            var thirdValue = string.Empty;
            if (input.Length == 5)
            {
                thirdValue = input[3] + " " + input[4];
            }
            else
            {
                thirdValue = input[3];
            }
            var threeuple = new Threeuple<string, string,string>(value, secondValue,thirdValue);
            Console.WriteLine(threeuple.ToString());

            input = Console.ReadLine().Split();
            value = input[0];
            var ssecondValue = int.Parse(input[1]);
            var drunkOrNot = input[2];
            var isDrunk = false;
            if(drunkOrNot == "drunk")
            {
                isDrunk = true; //thirdValue bool
                
            }                
            var secondThreeuple = new Threeuple<string, int, bool>(value, ssecondValue,isDrunk);
            Console.WriteLine(secondThreeuple.ToString());

            input = Console.ReadLine().Split();
            value = (input[0]);
            var doubleValue = double.Parse(input[1]);
            thirdValue = input[2];

            var thirdThreeuple = new Threeuple<string, double, string>(value,doubleValue,thirdValue);
            Console.WriteLine(thirdThreeuple.ToString());
        }
    }
}
