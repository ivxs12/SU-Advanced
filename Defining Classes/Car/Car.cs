namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; private set; } = "VW";
        public string Model { get; private set; } = "Golf";
        public int Year { get; private set; } = 2025;
        public double FuelQuantity { get; private set; } = 200;
        public double FuelConsumption { get; private set; } = 10;
        public Engine Engine { get; private set; }
        public Tire[] Tire { get; private set; }


        public Car()
        {

        }
        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car (string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year,fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tire = tires;
        }
        public void Drive(double distance)
        {
            if (this.FuelQuantity - distance * (this.FuelConsumption / 100) > 0)
            {
                this.FuelQuantity = this.FuelQuantity - distance * (this.FuelConsumption / 100);
            }
            else
            {
                System.Console.WriteLine("Not enough fuel to perform this trip!");
            }      
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nHorsePowers: {this.Engine.HorsePower}\nFuelQuantity: {this.FuelQuantity}";
        }
    }
}
