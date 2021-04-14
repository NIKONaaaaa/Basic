namespace LineNumbers
{
    using System.IO;
    class StartUp
    {
        static void Main()
        {
            using var reader = new StreamReader("Input.txt");
            string line = reader.ReadLine();
            int counter = 1;
            using var writer = new StreamWriter("Output.txt");
            while (line != null)
            {
                writer.WriteLine($"{counter}. {line}");
                line = reader.ReadLine();
                counter++;
            }
            reader.Close();
            writer.Close();
        }
    }
}