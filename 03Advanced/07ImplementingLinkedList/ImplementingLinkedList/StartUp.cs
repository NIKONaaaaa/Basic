namespace ImplementingLinkedList
{
    using System;
    class StartUp
    {
        static void Main()
        {
            CustomLinkedList<string> test = new CustomLinkedList<string>();
            test.Add(new CustomLinkedList<string>.Node<string>("a"));
            test.Add(new CustomLinkedList<string>.Node<string>("s"));
            test.Add(new CustomLinkedList<string>.Node<string>("d"));
            test.Add(new CustomLinkedList<string>.Node<string>("f"));
            test.Add(new CustomLinkedList<string>.Node<string>("g"));
            foreach (var i in test)
            {
                Console.WriteLine(i);
            }
        }
    }
}