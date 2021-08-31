using System;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[][] matrix = new string[n][];

            int collect = 0;
            int collectOpponent = 0;

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                matrix[i] = arr;
            }

            string[] comm = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (comm[0] != "Gong")
            {
                switch (comm[0])
                {
                    case "Find":
                        if (Convert.ToInt32(comm[1]) < n && Convert.ToInt32(comm[2]) < matrix[Convert.ToInt32(comm[1])].Length)
                        {
                            if (matrix[Convert.ToInt32(comm[1])][Convert.ToInt32(comm[2])] == "T")
                            {
                                matrix[Convert.ToInt32(comm[1])][Convert.ToInt32(comm[2])] = "-";
                                collect++;
                            }
                        }
                        break;
                    case "Opponent":
                        switch (comm[3])
                        {
                            case "up":
                                if (Convert.ToInt32(comm[1]) < n)
                                {
                                    for (int i = Convert.ToInt32(comm[1]); i >= 0; i--)
                                    {
                                        if (matrix[i].Length > Convert.ToInt32(comm[2]))
                                        {
                                            if (matrix[i][Convert.ToInt32(comm[2])] == "T")
                                            {
                                                collectOpponent++;
                                                matrix[i][Convert.ToInt32(comm[2])] = "-";
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    for (int i = n - 1; i >= 0; i--)
                                    {
                                        if (matrix[i].Length > Convert.ToInt32(comm[2]))
                                        {
                                            if (matrix[i][Convert.ToInt32(comm[2])] == "T")
                                            {
                                                collectOpponent++;
                                                matrix[i][Convert.ToInt32(comm[2])] = "-";
                                            }
                                        }
                                    }
                                }
                                break;
                            case "down":
                                if (Convert.ToInt32(comm[1]) < n)
                                {
                                    for (int i = Convert.ToInt32(comm[1]); i < n; i++)
                                    {
                                        if (matrix[i].Length > Convert.ToInt32(comm[2]))
                                        {
                                            if (matrix[i][Convert.ToInt32(comm[2])] == "T")
                                            {
                                                collectOpponent++;
                                                matrix[i][Convert.ToInt32(comm[2])] = "-";
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    for (int i = n - 1; i < n; i++)
                                    {
                                        if (matrix[i].Length > Convert.ToInt32(comm[2]))
                                        {
                                            if (matrix[i][Convert.ToInt32(comm[2])] == "T")
                                            {
                                                collectOpponent++;
                                                matrix[i][Convert.ToInt32(comm[2])] = "-";
                                            }
                                        }
                                    }
                                }
                                break;
                            case "right":
                                if (Convert.ToInt32(comm[1]) < n && Convert.ToInt32(comm[2]) < matrix[Convert.ToInt32(comm[1])].Length)
                                {
                                    for (int i = Convert.ToInt32(comm[2]); i < matrix[Convert.ToInt32(comm[1])].Length; i++)
                                    {
                                        if (matrix[Convert.ToInt32(comm[1])][i] == "T")
                                        {
                                            collectOpponent++;
                                            matrix[Convert.ToInt32(comm[1])][i] = "-";
                                        }
                                    }
                                }
                                else
                                {
                                    for (int i = matrix[Convert.ToInt32(comm[1])].Length - 1; i < matrix[Convert.ToInt32(comm[1])].Length; i++)
                                    {
                                        if (matrix[Convert.ToInt32(comm[1])][i] == "T")
                                        {
                                            collectOpponent++;
                                            matrix[Convert.ToInt32(comm[1])][i] = "-";
                                        }
                                    }
                                }
                                break;
                            case "left":
                                if (Convert.ToInt32(comm[1]) < n && Convert.ToInt32(comm[2]) < matrix[Convert.ToInt32(comm[1])].Length)
                                {
                                    for (int i = Convert.ToInt32(comm[2]); i >= 0; i--)
                                    {
                                        if (matrix[Convert.ToInt32(comm[1])][i] == "T")
                                        {
                                            collectOpponent++;
                                            matrix[Convert.ToInt32(comm[1])][i] = "-";
                                        }
                                    }
                                }
                                else
                                {
                                    for (int i = matrix[Convert.ToInt32(comm[1])].Length - 1; i >= 0; i--)
                                    {
                                        if (matrix[Convert.ToInt32(comm[1])][i] == "T")
                                        {
                                            collectOpponent++;
                                            matrix[Convert.ToInt32(comm[1])][i] = "-";
                                        }
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                comm = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
            Console.WriteLine($"Collected tokens: {collect}");
            Console.WriteLine($"Opponent's tokens: {collectOpponent}");
        }
    }
}
