namespace ImplementingLinkedList
{
    using System;
    public class CustomStack
    {
        private const int initialCapacity = 4;
        private int[] items;
        private int count;
        public int Count
        {
            get
            {
                return this.count;
            }
        }
        public CustomStack()
        {
            this.count = 0;
            this.items = new int[initialCapacity];
        }
        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];
            Array.Copy(this.items, copy, this.count);
            this.items = copy;
        }
        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];
            Array.Copy(this.items, copy, this.count);
            this.items = copy;
        }
        private void CheckIfEmpty()
        {
            if (this.items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }
        }
        public void Push(int element)
        {
            if (this.items.Length == this.count)
            {
                this.Resize();
            }
            this.items[this.count] = element;
            count++;
        }
        public int Pop()
        {
           this.CheckIfEmpty();
            int last = this.items[this.count - 1];
            this.items[this.count - 1] = default;
            this.count--;
            if (this.count == this.items.Length / 4)
            {
                this.Shrink();
            }
            return last;
        }
        public int Peek()
        {
            this.CheckIfEmpty();
            return this.items[this.count - 1];
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.items[i]);
            }
        }
    }
}