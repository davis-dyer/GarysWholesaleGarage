using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero("black");
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram trx = new Ram();



            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            trx.Drive();
        }
    }
}
