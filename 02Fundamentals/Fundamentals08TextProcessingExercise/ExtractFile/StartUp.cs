namespace ExtractFile
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string[] pathName = Console.ReadLine().Split("\\");
            string[] file = pathName[^1].Split(".");
            Console.Write($"File name: {file[0]}\nFile extension: {file[1]}");
        }
    }
}