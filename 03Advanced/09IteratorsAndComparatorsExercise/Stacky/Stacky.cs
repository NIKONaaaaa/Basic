namespace Stacky
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class Stacky<T> : IEnumerable<T>
    {
        private List<T> items;
        public Stacky()
        {
            this.items = new List<T>();
        }
        public Stacky(List<T> items)
        {
            this.items = items;
        }

        public void Push(T item)
        {
            this.items.Add(item);
        }

        public T Pop()
        {
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            int index = this.items.Count - 1;
            T item = this.items[index];
            this.items.RemoveAt(index);
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.items.Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}