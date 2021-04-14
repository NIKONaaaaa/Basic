namespace ImplementingLinkedList
{
    using System;
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;
        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }
        public int Count { get; private set; }
        public int this[int index]
        {
            get
            {
                if (0 > index || this.Count <= index)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (0 > index || this.Count <= index)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }
        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }
        private void Shift(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }
        private void ShiftRight(int index)
        {
            for (int i = this.Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
        }
        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        public int RemoveAt(int index)
        {
            if (0 > index || this.Count <= index)
            {
                throw new ArgumentOutOfRangeException();
            }
            var item = this.items[index];
            this.items[index] = default(int);
            this.Shift(index);
            this.Count--;
            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }
            return item;
        }
        public void Insert(int index, int element)
        {
            if (0 > index || this.Count < index)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.ShiftRight(index);
            this.items[index] = element;
            this.Count++;
        }
        public bool Contains(int number)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i] == number)
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            if (0 > firstIndex || firstIndex > this.Count || 0 > secondIndex || secondIndex > this.Count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            int firstNum = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = firstNum;
        }
    }
}