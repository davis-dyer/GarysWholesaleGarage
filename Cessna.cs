using System;

namespace Garage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
            
        }
        public override void Drive()
        {
            // method definition omitted
            Console.WriteLine($"The {MainColor} goes Zoooooom!");
        }
    }
}