using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();


            while (command != "No more tires")
            {
                double[] input = command.Split().Select(double.Parse).ToArray();
                Tire[] tire = new Tire[4]
                {
                    new Tire(Convert.ToInt32(input[0]), input[1]),
                    new Tire(Convert.ToInt32(input[2]), input[3]),
                    new Tire(Convert.ToInt32(input[4]), input[5]),
                    new Tire(Convert.ToInt32(input[6]), input[7]),
                };
                tires.Add(tire);
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "Engines done")
            {
                double[] input = command.Split().Select(double.Parse).ToArray();
                Engine engine = new Engine(Convert.ToInt32(input[0]), input[1]);
                engines.Add(engine);
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "Show special")
            {
                string[] input = command.Split();
                Car car = new Car(input[0], input[1], Convert.ToInt32(input[2]),
                    Convert.ToDouble(input[3]), Convert.ToDouble(input[4]), engines[Convert.ToInt32(input[5])], tires[Convert.ToInt32(input[6])]);
                cars.Add(car);
                command = Console.ReadLine();
            }
            cars = cars.Where(x => x.Year >= 2017).Where(x => x.Engine.HorsePower > 330).
                Where(x => x.Tire[0].Pressure + x.Tire[1].Pressure + x.Tire[2].Pressure + x.Tire[3].Pressure > 9).
                Where(x => x.Tire[0].Pressure + x.Tire[1].Pressure + x.Tire[2].Pressure + x.Tire[3].Pressure < 10).ToList();
            foreach(Car car in cars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
