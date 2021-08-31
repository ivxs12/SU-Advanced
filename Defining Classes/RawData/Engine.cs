namespace RawData
{
    class Engine
    {
        public double EngineSpeed { get; set; }
        public double EnginePower { get; set; }
        public Engine()
        {

        }
        public Engine(double speed, double power) : this()
        {
            this.EngineSpeed = speed;
            this.EnginePower = power;
        }
    }
}
