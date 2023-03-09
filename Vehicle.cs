using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public string MaxSpeed {get; set;}

        public virtual void Drive()
        {
            Console.WriteLine($"The {MainColor} Vrooom!");
        }

        public virtual string Turn(string direction)
        {
            string outcome = "steady";
            if (direction == "left")
            {
                Console.WriteLine("Watch out AHHHH");
            }

            return $"Car {MainColor} is turning {outcome}";
        }
        public virtual string Stop(string chance)
        {
            string outcome = "Can we stop?";
            if (chance == "l")
            {
                Console.WriteLine("Glad we slowed down.");
            }

            return $"Car {MainColor} is thinking {outcome}";
        }

    }
}