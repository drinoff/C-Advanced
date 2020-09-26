using System;

namespace dateModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {            
            var datemodifier = new DateModifier();
            datemodifier.StartDate = DateTime.Parse(Console.ReadLine());
            datemodifier.EndDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(Math.Abs(datemodifier.DayDifference()));
        }
    }
}
