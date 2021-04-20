namespace InvalidNumber
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool check = false;
            if ((100 <= number && number <= 200) || number == 0)
            {
                check = true;
            }    
            if (check == false)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}