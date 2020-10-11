using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stack
{
    class MyStack<T> : IEnumerable<T>
    {
        public List<T> Collection = new List<T>();

        public List<T> Push(T value)
        {
            Collection.Add(value);
            return Collection;
        }
        public void Pop()
        {
            if (Collection.Any())
            {
                Collection.RemoveAt(Collection.Count - 1);
            }
            else
            {
                throw new InvalidOperationException("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Collection.Count-1; i >= 0; i--)
            {
                yield return Collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Collection.GetEnumerator();
        }
        
    }
}
