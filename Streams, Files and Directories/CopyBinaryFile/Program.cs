using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CopyBinaryFile
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const int BYTE_BUFFER = 4096;

            using (FileStream reader = new FileStream("copyMe.png", FileMode.Open, FileAccess.Read))
            {
                using (FileStream writer = new FileStream("copyiedPicture.png", FileMode.Create, FileAccess.Write))
                {
                    while (reader.CanRead)
                    {
                        byte[] buffer = new byte[BYTE_BUFFER];
                        int readBytes = await reader.ReadAsync(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            return;
                        }
                        await writer.WriteAsync(buffer, 0, readBytes);
                    }
                }
            }

                
        }
    }
}
