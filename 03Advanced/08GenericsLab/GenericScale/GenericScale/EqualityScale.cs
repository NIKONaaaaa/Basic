namespace GenericScale
{
    using System;
    public class EqualityScale<T> where T : IComparable
    {
        private T left;
        private T right;
        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }
        public bool AreEqual()
        {
            int result = left.CompareTo(right);
            return result == 0;
        }
    }
}