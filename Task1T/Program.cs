using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1T
{
    class Program
    {
        static void Main(string[] args)
        {
            Locomotive loc = new Locomotive(10,10,10,200,"black","gas",100,10,50000);
            PassengerCar passenger = new PassengerCar(10,10,10,100,"black",40,"kype",5,100);
            CreateTrain train = new CreateTrain(loc);
            for (int i = 0; i < 6; i++)
            {
                train.Add(passenger);
            }
            PassengerCar passenger1 = new PassengerCar(10, 10, 10, 100, "black", 90, "kype", 5, 100);
            train.Add(passenger1);
            train.FindAllCarsByPlaces(50, 100);
            Console.ReadKey();
        }
    }
}
