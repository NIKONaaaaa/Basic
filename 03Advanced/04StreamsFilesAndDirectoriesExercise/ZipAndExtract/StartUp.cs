namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;
    class StartUp
    {
        static void Main()
        {
            string zipFilePath = "../../../copyMe.zip";
            string fileName = "copyMe.png";
            string extractPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ZipAndExtract Output");
            using ZipArchive compressedFile = ZipFile.Open(zipFilePath, ZipArchiveMode.Update);
            if (compressedFile.GetEntry(fileName) == null)
            {
                compressedFile.CreateEntryFromFile($"../../../{fileName}", fileName);
            }
            compressedFile.ExtractToDirectory(extractPath, true);
        }
    }
}