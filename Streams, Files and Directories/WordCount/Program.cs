using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Dictionary<string, int> allWords = new Dictionary<string, int>();
            List<string> wordsList = new List<string>();
            using (StreamReader words = new StreamReader("words.txt"))
            {
                string singleWord = await words.ReadLineAsync();
                while (singleWord != null)
                {
                    wordsList.Add(singleWord);
                    singleWord = await words.ReadLineAsync();
                }
            }
            using (StreamReader text = new StreamReader("text.txt"))
            {
                string line = await text.ReadLineAsync();
                while (line != null)
                {
                    string[] fullText = line.Split().Select(x => x.Trim(new char[] { ',', '.', '-', '!', '?' })).Select(x => x.ToLower()).ToArray();
                    foreach (string word in fullText)
                    {
                        if (wordsList.Contains(word))
                        {
                            if (allWords.ContainsKey(word))
                            {
                                allWords[word]++;
                            }
                            else
                            {
                                allWords.Add(word, 1);
                            }
                        }
                    }
                    line = await text.ReadLineAsync();
                }
            }
            await CreateFile(allWords);
            await CompareFiles("actualResult.txt", "expectedResult.txt");
        }
        static async Task CreateFile(Dictionary<string, int> input)
        {
            using (StreamWriter wrt = File.CreateText("actualResult.txt"))
            {
                foreach (var word in input.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value))
                {
                    await wrt.WriteLineAsync($"{word.Key} - {word.Value}");
                }
            }
        }
        static async Task CompareFiles(string firstFile, string secondFile)
        {
            using (StreamReader exp = new StreamReader(firstFile))
            {
                using (StreamReader act = new StreamReader(secondFile))
                {
                    string first = await exp.ReadLineAsync();
                    string second = await act.ReadLineAsync();
                    while (first != null && second != null)
                    {
                        if (first == second)
                        {
                            return;
                        }
                        else
                        {
                            throw new ArgumentException("The results do not match");
                        }
                        first = await exp.ReadLineAsync();
                        second = await act.ReadLineAsync();
                    }
                }
            }
        }
    }
}
