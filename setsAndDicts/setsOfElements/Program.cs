using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace setsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var setOne = new HashSet<string>();
            var setTwo = new HashSet<string>();
            var identicalsSet = new HashSet<string>();
            var NandM = Console.ReadLine().Split().Select(int.Parse).ToArray() ;
            var N = NandM[0];
            var M = NandM[1];
            

            for (int i = 0; i < N+M; i++)
            {
                var input = Console.ReadLine();
                if(i>=N)
                {
                    setTwo.Add(input);
                }
                else
                {
                    setOne.Add(input);
                }
            }
           
            Console.WriteLine(string.Join(" ",IdenticalElementsFinder(setOne,setTwo,identicalsSet)));
        }
        public static HashSet<string> IdenticalElementsFinder(HashSet<string> setOne, HashSet<string>setTwo,HashSet<string>identicalsSet)
        {
            
            foreach (var element in setOne)
            {
                if(setTwo.Contains(element))
                {
                    identicalsSet.Add(element);
                }
            }

            return identicalsSet;
        }
    }
}
