using System.IO.Compression;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\Downloads", @"Streams, Files and Directories\ZipAndExtract\TestArchive.zip");
            ZipFile.ExtractToDirectory(@"C:\Downloads\TestArchive.zip", @"C:\Desktop\ZipAndExtractFolder");
        }
    }
}
