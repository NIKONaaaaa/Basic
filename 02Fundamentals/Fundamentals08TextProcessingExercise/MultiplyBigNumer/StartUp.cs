namespace MultiplyBigNumber
{
    using System;
    using System.Linq;
    using System.Text;
    class StartUp
    {
        static void Main()
        {
            string number = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());
            int carry = 0;
            StringBuilder result = new StringBuilder();
            if (multiplier == 0 || number == "")
            {
                result.Append("0");
            }
            else
            {
                foreach (char ch in number.Reverse())
                {
                    int digit = int.Parse(ch.ToString());
                    int multipliedDigit = digit * multiplier + carry;
                    if (9 < multipliedDigit)
                    {
                        carry = multipliedDigit / 10;
                        multipliedDigit %= 10;
                    }
                    else
                    {
                        carry = 0;
                    }
                    result.Insert(0, multipliedDigit);
                }
                if (carry != 0)
                {
                    result.Insert(0, carry);
                }
            }
            Console.WriteLine(result);
        }
    }
}