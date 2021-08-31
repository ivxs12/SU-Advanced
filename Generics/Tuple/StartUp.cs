using System;
using System.Collections.Generic;

namespace Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Tuple<string, string, string>> tuples = new List<Tuple<string, string, string>>();
            for (int i = 0; i < 3; i++)
            {
                string[] line = Console.ReadLine().Split();
                if (i == 0)
                {
                    if (line.Length > 4)
                    {
                        Tuple<string, string, string> tuple = new Tuple<string, string, string>(line[0] + " " + line[1], line[2], line[3] + " " + line[4]);
                        tuples.Add(tuple);
                    }
                    else
                    {
                        Tuple<string, string, string> tuple = new Tuple<string, string, string>(line[0] + " " + line[1], line[2], line[3]);
                        tuples.Add(tuple);
                    }


                }
                else
                {
                    Tuple<string, string, string> tuple = new Tuple<string, string, string>(line[0], line[1], line[2]);
                    tuples.Add(tuple);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"{tuples[i].FirstValue} -> {tuples[i].SecondValue} -> {tuples[i].ThirdValue}");
                }
                else if (i == 1)
                {
                    if (tuples[i].ThirdValue == "not")
                    {
                        Console.WriteLine($"{tuples[i].FirstValue} -> {tuples[i].SecondValue} -> {false}");
                    }
                    else
                    {
                        Console.WriteLine($"{tuples[i].FirstValue} -> {tuples[i].SecondValue} -> {true}");
                    }
                    
                }
                else if (i == 2)
                {
                    Console.WriteLine($"{tuples[i].FirstValue} -> {Convert.ToDouble(tuples[i].SecondValue):f1} -> {tuples[i].ThirdValue}");
                }    
            }    
        }
    }
}
