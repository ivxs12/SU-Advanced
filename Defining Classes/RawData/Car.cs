namespace RawData
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tire { get; set; }

        public Car()
        {

        }
        public Car(string model, Engine engine, Cargo cargo, Tire[] tire) : this()
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tire = tire;
        }
    }
}
