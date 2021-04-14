namespace GreaterOfTwoValues
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string inputType = Console.ReadLine(), one = Console.ReadLine(), two = Console.ReadLine();
            Console.WriteLine(GetMax(inputType, one, two));
        }
        static string GetMax(string data, string a, string b)
        {
            if (data == "int") return (Math.Max(int.Parse(a), int.Parse(b)).ToString());
            else if (data == "char")
            {
                char ch = (char)Math.Max(char.Parse(a), char.Parse(b));
                string output = ch.ToString();
                return output;
            }
            else
            {
                if (a.CompareTo(b) > 0) return a;
                else return b;
            }
        }
    }
}