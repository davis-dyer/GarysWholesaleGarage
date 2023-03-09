using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
            Console.Write("Lesssgooo");
        }

        public Zero(string bodyColor)
        {
            MainColor = "black";
        }

        public override void Drive()
        {
            // method definition omitted
            Console.WriteLine($"The {MainColor} goes Zoooooom!");
        }
    }
}