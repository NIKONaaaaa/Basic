namespace GenericBoxOfString
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                Console.WriteLine(box.ToString());
            }
        }
    }
}