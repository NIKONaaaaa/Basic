namespace Telephony
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] addresses = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (string number in numbers)
            {
                if (number.Length == 10)
                {
                    Smartphone newPhone = new Smartphone();
                    newPhone.Number = number;
                    Console.WriteLine(newPhone.CallNumber());
                }
                else
                {
                    StationaryPhone newPhone = new StationaryPhone(number);
                    newPhone.Number = number;
                    Console.WriteLine(newPhone.CallNumber());
                }
            }

            foreach (string address in addresses)
            {
                Smartphone newPhone = new Smartphone();
                newPhone.Address = address;
                Console.WriteLine(newPhone.BrowseAddress());
            }
        }
    }
}