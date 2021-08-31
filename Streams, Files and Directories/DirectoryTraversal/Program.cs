using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Dictionary<string, List<FileInfo>> filesByExtension = new Dictionary<string, List<FileInfo>>();

            string path = Console.ReadLine();
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                string extension = info.Extension;
                if (!filesByExtension.ContainsKey(extension))
                {
                    List<FileInfo> fileInfo = new List<FileInfo>();
                    foreach (var fileAgain in files)
                    {
                        FileInfo infoAgain = new FileInfo(fileAgain);
                        if (infoAgain.Extension == extension)
                        {
                            fileInfo.Add(infoAgain);
                        }
                    }
                    filesByExtension.Add(info.Extension, fileInfo);
                }
            }
            using (StreamWriter wrt = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt"))
            {
                foreach (var extension in filesByExtension.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value))
                {
                    await wrt.WriteLineAsync(extension.Key);
                    foreach (var item in extension.Value.OrderBy(x => x.Length))
                    {
                        await wrt.WriteLineAsync($"--{item.Name} - {Math.Ceiling((double) item.Length / 1024)}kb");
                    }
                }
            }
        }
    }
}
