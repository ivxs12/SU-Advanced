using System;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace EvenLines
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int count = 0;
            using (StreamReader str = new StreamReader("text.txt"))
            {
                var line = await str.ReadLineAsync();
                while (line != null)
                {
                    if (count % 2 == 0)
                    {
                        string lineStr2 = " ";
                        string lineStr = line.ToString();
                        for (int i = 0; i < lineStr.Length; i++)
                        {
                            if (lineStr[i] == '-' || lineStr[i] == ',' || lineStr[i] == '.' || lineStr[i] == '!' || lineStr[i] == '?')
                            {
                                lineStr2 += "@";
                            }
                            else
                            {
                                lineStr2 += lineStr[i];
                            }
                        }
                        string[] finalLine = lineStr2.Split().ToArray();
                        Console.WriteLine(string.Join(" ", finalLine.Reverse()));
                    }
                    count++;
                    line = await str.ReadLineAsync();
                }
            }
        }
    }
}
