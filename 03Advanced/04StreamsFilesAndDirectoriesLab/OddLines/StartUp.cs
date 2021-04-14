namespace OddLines
{
    using System.IO;
    class StartUp
    {
        static void Main()
        {
            using var reader = new StreamReader("Input.txt");
            int counter = 0;
            string line = reader.ReadLine();
            using var writer = new StreamWriter("Output.txt");
            while (line != null)
            {
                if (counter % 2 == 1)
                {
                    writer.WriteLine(line);
                }
                counter++;
                line = reader.ReadLine();
            }
            reader.Close();
            writer.Close();
        }
    }
}