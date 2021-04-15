namespace CustomStack
{
    using System.Collections.Generic;
    public class StackOfStrings : Stack<string>
    {
        private Stack<string> stackContents;

        public StackOfStrings()
        {
            this.stackContents = new Stack<string>();
        }

        public bool IsEmpty()
        {
            return stackContents.Count == 0;
        }

        public Stack<string> AddRange(IEnumerable<string> items)
        {
            foreach (string item in items)
            {
                stackContents.Push(item);
            }

            return stackContents;
        }
    }
}