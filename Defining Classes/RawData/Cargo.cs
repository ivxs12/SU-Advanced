namespace RawData
{
    class Cargo
    {
        public double CargoWeight { get; set; }
        public string CargoType { get; set; }

        public Cargo()
        {

        }
        public Cargo(double cargoWeight, string cargoType) : this()
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }

    }
}
