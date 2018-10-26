using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1T
{
    class PassengerCar : Car
    {
        private int _numberofPlaces;
        private string _type;
        private double _comfort;
        private double _loadCapacity;

        public PassengerCar(double length, double width, double height, double weight, 
            string color, int numberofPlaces, string type, double comfort, double loadCapacity) : 
            base(length, width, height, weight, color)
        {
            _numberofPlaces = numberofPlaces;
            _type = type;
            _comfort = comfort;
            _loadCapacity = loadCapacity;
        }



    }
}
