namespace CommonElements
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string[] arrayOne = Console.ReadLine().Split(' '), arrayTwo = Console.ReadLine().Split(' ');
            var arrayThree = arrayTwo.Intersect(arrayOne);
            Console.WriteLine(string.Join(' ', arrayThree));
        }
    }
}