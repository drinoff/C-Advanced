using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    class ListyIterator<T> : IEnumerable<T>
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
            if (index == List.Count - 1)
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
            if (List.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"{List[index]}");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in List)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public void PrintAll()
        {
            if (this.List.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(string.Join(" ", this.List));




        }
    }
}
