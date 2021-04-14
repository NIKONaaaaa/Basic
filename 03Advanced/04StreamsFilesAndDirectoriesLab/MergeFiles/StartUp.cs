namespace MergeFiles
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<int> fileContents = new List<int>();
            using (StreamReader reader = new StreamReader("FileOne.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    fileContents.Add(int.Parse(line));
                    line = reader.ReadLine();
                }
            }
            using (StreamReader reader = new StreamReader("FileTwo.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    fileContents.Add(int.Parse(line));
                    line = reader.ReadLine();
                }
            }
            using (StreamWriter writer = new StreamWriter("FileOut.txt"))
            {
                foreach (int item in fileContents.OrderBy(value => value))
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}