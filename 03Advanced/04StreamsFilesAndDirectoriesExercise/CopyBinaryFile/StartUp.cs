namespace CopyBinaryFile
{
    using System.IO;
    class StartUp
    {
        static void Main()
        {
            using (FileStream writer = new FileStream("../../../copyOfFile.png", FileMode.Create, FileAccess.Write))
            {
                using (FileStream reader = new FileStream("copyMe.png", FileMode.Open, FileAccess.Read))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        int count = reader.Read(buffer, 0, buffer.Length);
                        if (count == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}