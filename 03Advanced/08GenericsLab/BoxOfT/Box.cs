namespace BoxOfT
{
    using System;
    using System.Collections.Generic;
    public class Box<T>
    {
        public List<T> List { get; set; }
        public int Count => List.Count;
        public Box()
        {
            List = new List<T>();
        }
        public void Add(T element)
        {
            List.Add(element);
        }
        public T Remove()
        {
            if (Count == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            T element = List[Count - 1];
            List.RemoveAt(Count - 1);
            return element;
        }
    }
}