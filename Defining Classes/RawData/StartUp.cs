using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
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
                Engine engine = new Engine(Convert.ToDouble(input[1]), Convert.ToDouble(input[2]));
                Cargo cargo = new Cargo(Convert.ToDouble(input[3]), input[4]);
                Tire[] tire = new Tire[4]
                {
                    new Tire(Convert.ToDouble(input[5]), Convert.ToDouble(input[6])),
                    new Tire(Convert.ToDouble(input[7]), Convert.ToDouble(input[8])),
                    new Tire(Convert.ToDouble(input[9]), Convert.ToDouble(input[10])),
                    new Tire(Convert.ToDouble(input[11]), Convert.ToDouble(input[12])),
                };
                Car car = new Car(input[0], engine, cargo, tire);
                cars.Add(car);
            }
            string comm = Console.ReadLine();
            if (comm == "fragile")
            {
                cars.Where(x => x.Cargo.CargoType == comm).Where(x => x.Tire.Any(y => y.TirePressure < 1)).ToList().ForEach(x => Console.WriteLine(x.Model));
            }
            else
            {
                cars.Where(x => x.Cargo.CargoType == comm).Where(x => x.Engine.EnginePower > 250).ToList().ForEach(x => Console.WriteLine(x.Model));
            }
            
        }
    }
}
