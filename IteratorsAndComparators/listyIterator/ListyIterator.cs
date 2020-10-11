using System;
using System.Collections.Generic;
using System.Text;

namespace listyIterator
{
    class ListyIterator<T>
    {
        private int index = 0;

        public List<T> List = new List<T>();
        public ListyIterator(List<T> list)
        {
            List = list;
        }

        public bool Move()
        {
            if (index + 1 < List.Count)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HasNext()
        {
            if(index == List.Count-1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Print()
        {
            if(List.Count==0)
            {
                Console.WriteLine("Invalid Operation!");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"{List[index]}");
            }
        }                
    }
}
