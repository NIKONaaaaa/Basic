namespace DirectoryTraversal
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string dirPath = Directory.GetCurrentDirectory();
            string[] fileNames = Directory.GetFiles(dirPath);
            Dictionary<string, Dictionary<string, double>> fileData = new Dictionary<string, Dictionary<string, double>>();
            foreach (string file in fileNames)
            {
                FileInfo fileInfo = new FileInfo(file);
                string fileExtension = fileInfo.Extension;
                double fileSize = Math.Round(fileInfo.Length / 1024.0, 3);
                if (!fileData.ContainsKey(fileExtension))
                {
                    fileData.Add(fileExtension, new Dictionary<string, double>());
                }
                fileData[fileExtension].Add(fileInfo.Name, fileSize);
            }
            Dictionary<string, Dictionary<string, double>> sortedFileData = fileData
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            List<string> results = new List<string>();
            foreach (var file in sortedFileData)
            {
                results.Add(file.Key);
                {
                    results.AddRange(file.Value.OrderBy(kvp => kvp.Value).Select(fullFileInfo => $"--{fullFileInfo.Key} - {fullFileInfo.Value}kb"));
                }
            }
            string resultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "report.txt");
            File.WriteAllLines(resultPath, results);
        }
    }
}