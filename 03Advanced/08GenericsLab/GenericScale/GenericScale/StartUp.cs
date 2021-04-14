namespace GenericScale
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            EqualityScale<int> equality = new EqualityScale<int>(3, 8);
            Console.WriteLine(equality.AreEqual());
        }
    }
}