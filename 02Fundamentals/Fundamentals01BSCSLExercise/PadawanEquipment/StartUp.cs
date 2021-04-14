namespace PadawanEquipment
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double total = (Math.Ceiling(1.1 * students) * lightsaberPrice) + students * robePrice + (students - Math.Floor(students / 6)) * beltPrice;
            if (total <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total - budget:f2}lv more.");
            }
        }
    }
}