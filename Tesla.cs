using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
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