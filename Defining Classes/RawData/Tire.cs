namespace RawData
{
    class Tire
    {
        public double TirePressure { get; set; }
        public double TireAge { get; set; }

        public Tire()
        {

        }
        public Tire(double tirePressure, double tireAge) : this()
        {
            this.TirePressure = tirePressure;
            this.TireAge = tireAge;
        }
    }
}
