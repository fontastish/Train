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
            GitCheck.Print();
            Locomotive loc = new Locomotive(10,10,10,200,"black","gas",100,10,50000);
            PassengerCar passenger = new PassengerCar(10,10,10,100,"black",40,"kype",5,100);
            TrainBuilder trainBuilder = new TrainBuilder(loc);
            PassengerCar passenger1 = new PassengerCar(10, 10, 10, 100, "black", 90, "kype", 0, 100);
            PassengerCar passenger2 = new PassengerCar(10, 10, 10, 100, "black", 90, "kype", 1, 100);
            PassengerCar passenger3 = new PassengerCar(10, 10, 10, 100, "black", 90, "kype", 4, 100);
            PassengerCar passenger4 = new PassengerCar(10, 10, 10, 100, "black", 90, "kype", 2, 100);
            trainBuilder.Add(passenger1);
            trainBuilder.Add(passenger2);
            trainBuilder.Add(passenger3);
            trainBuilder.Add(passenger4);
            trainBuilder.FindAllCarsByPlaces(50, 100);
            trainBuilder.SortComfort();
            Console.ReadKey();
        }
    }
}
