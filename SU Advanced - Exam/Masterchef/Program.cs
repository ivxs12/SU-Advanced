using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ingredients = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] freshness = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> ingredientsCollection = new Queue<int>();
            Stack<int> freshnessCollection = new Stack<int>();
            Dictionary<string, int> dishes = new Dictionary<string, int>();
            for (int i = 0; i < ingredients.Length; i++)
            {
                ingredientsCollection.Enqueue(ingredients[i]);
            }
            for (int i = 0; i < freshness.Length; i++)
            {
                freshnessCollection.Push(freshness[i]);
            }

            int remaining = 0;

            while (ingredientsCollection.Count != 0)
            { 
                int ingredient = ingredientsCollection.Dequeue();
                if (ingredient != 0 && freshnessCollection.Count != 0)
                {
                    int fresh = freshnessCollection.Pop();
                    int dish = ingredient * fresh;
                    switch (dish)
                    {
                        case 150:
                            if (dishes.ContainsKey("Dipping sauce"))
                            {
                                dishes["Dipping sauce"]++;
                            }
                            else
                            {
                                dishes.Add("Dipping sauce", 1);
                            }
                            break;
                        case 250:
                            if (dishes.ContainsKey("Green salad"))
                            {
                                dishes["Green salad"]++;
                            }
                            else
                            {
                                dishes.Add("Green salad", 1);
                            }
                            break;
                        case 300:
                            if (dishes.ContainsKey("Chocolate cake"))
                            {
                                dishes["Chocolate cake"]++;
                            }
                            else
                            {
                                dishes.Add("Chocolate cake", 1);
                            }
                            break;
                        case 400:
                            if (dishes.ContainsKey("Lobster"))
                            {
                                dishes["Lobster"]++;
                            }
                            else
                            {
                                dishes.Add("Lobster", 1);
                            }
                            break;
                        default:
                            ingredientsCollection.Enqueue(ingredient + 5);
                            break;
                    }
                }
                else if (ingredient == 0)
                {

                }
                else if (ingredient != 0 && freshnessCollection.Count == 0)
                {
                    remaining += ingredient;
                }
            }
            dishes = dishes.OrderBy(x => x.Key).OrderByDescending(x => x.Value).ToDictionary(t => t.Key, t => t.Value);
            if (dishes.Count >= 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                if (remaining != 0)
                {
                    Console.WriteLine($"Ingredients left: {remaining}");
                }
                foreach (var dish in dishes)
                {
                    Console.WriteLine($"# {dish.Key} --> {dish.Value}");
                }
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if (remaining != 0)
                {
                    Console.WriteLine($"Ingredients left: {remaining}");
                }
                foreach (var dish in dishes)
                {
                    Console.WriteLine($"# {dish.Key} --> {dish.Value}");
                }
            }
        }
    }
}
