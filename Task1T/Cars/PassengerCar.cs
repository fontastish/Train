using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1T
{
    public class PassengerCar : Car
    {
        public int NumberOfPlaces { get; set; }
        public string Type { get; set; }
        public double Comfort { get; set; }
        public double LoadCapacity { get; set; }

        public PassengerCar(double length, double width, double height, double weight, string color,
            int numberOfPlaces, string type, double comfort, double loadCapacity) : 
            base(length, width, height, weight, color)
        {
            NumberOfPlaces = numberOfPlaces;
            Type = type;
            Comfort = comfort;
            LoadCapacity = loadCapacity;
        }

        public override double TotalWeight()
        {
            return Weight + LoadCapacity + (NumberOfPlaces * 70);
        }

        public static int CompareByComfort(PassengerCar car1,PassengerCar car2)
        {
            return car1.Comfort.CompareTo(car2.Comfort);
        }
    }
}
