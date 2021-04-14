namespace SliceAFile
{
    using System.IO;
    class StartUp
    {
        static void Main()
        {
            using (FileStream reader = new FileStream("../../../sliceMe.txt", FileMode.Open))
            {
                byte[] buffer = new byte[reader.Length / 4];
                for (int i = 1; i <= reader.Length / buffer.Length; i++)
                {
                    reader.Read(buffer, 0, buffer.Length);
                    using (FileStream writer = new FileStream($"../../../Part-{i}.txt", FileMode.Create, FileAccess.Write))
                    {
                        writer.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}