using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Car car = new Car(input[0], Convert.ToDouble(input[1]), Convert.ToDouble(input[2]));
                cars.Add(car);
            }
            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0] == "Drive")
                {
                    cars.Find(x => x.Model == command[1]).Drive(Convert.ToInt32(command[2]));
                }
                command = Console.ReadLine().Split();
            }
            cars.ForEach(x => Console.WriteLine($"{x.Model} {x.FuelAmount:f2} {x.TraveledDistance}"));
        }
    }
}
