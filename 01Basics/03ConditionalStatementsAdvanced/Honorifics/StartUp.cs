namespace PersonalTitles
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();
            string honorific = "";
            if (gender == "f")
            {
                if (age < 16)
                {
                    honorific = "Miss";
                }
                else
                {
                    honorific = "Ms.";
                }
            }
            else if (gender == "m")
            {
                if (age < 16)
                {
                    honorific = "Master";
                }
                else
                {
                    honorific = "Mr.";
                }
            }
            Console.WriteLine($"{honorific}");
        }
    }
}