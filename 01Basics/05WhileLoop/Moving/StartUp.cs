namespace Moving
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int roomWidth = int.Parse(Console.ReadLine());
            int roomLength = int.Parse(Console.ReadLine());
            int roomHeight = int.Parse(Console.ReadLine());
            int roomSize = roomWidth * roomLength * roomHeight;
            string input = Console.ReadLine();
            while (0 < roomSize && input != "Done")
            {
                roomSize -= int.Parse(input);
                input = Console.ReadLine();
            }
            if (0 <= roomSize)
            {
                Console.WriteLine($"{roomSize} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(roomSize)} Cubic meters more.");
            }
        }
    }
}