using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;

        public Car()
        {

        }
        public Car(string model, double fuelAmount, double fuelConsumption) : this()
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
        }
        public string Model { get; set; }
        public double FuelAmount 
        {
            get => this.fuelAmount;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel cannot be a negative number");
                }
                else
                {
                    this.fuelAmount = value;
                }
            }
        }
        public double FuelConsumptionPerKilometer
        {
            get => this.fuelConsumptionPerKilometer;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel consumption cannot be a negative number or zero");
                }
                else
                {
                    this.fuelConsumptionPerKilometer = value;                  
                }
            }
        }
        public double TraveledDistance { get; set; }

        public void Drive(int kilometers)
        {
            if (this.FuelAmount - this.FuelConsumptionPerKilometer * kilometers >= 0)
            {
                this.FuelAmount = this.FuelAmount - this.FuelConsumptionPerKilometer * kilometers;
                this.TraveledDistance += kilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
