using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LineNumbers
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader str = new StreamReader("text.txt"))
            {
                string line = await str.ReadLineAsync();

                using (StreamWriter wrt = File.CreateText("output.txt"))
                {
                    Regex rgx = new Regex(@"[A-Za-z]");
                    Regex rgx2 = new Regex(@"[!.,'-?]");
                    int count = 1;
                    int letters = 0;
                    int characters = 0;
                    while (line != null)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (rgx.IsMatch(line[i].ToString()))
                            {
                                letters++;
                            }
                            else if (rgx2.IsMatch(line[i].ToString()))
                            {
                                characters++;
                            }
                        }
                        await wrt.WriteLineAsync($"Line {count}:{line}({letters})({characters})");
                        count++;
                        letters = 0;
                        characters = 0;
                        line = await str.ReadLineAsync();
                    }
                    wrt.Close();
                }
            }
        }
    }
}
