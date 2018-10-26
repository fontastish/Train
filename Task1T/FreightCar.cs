using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1T
{
    class FreightCar: Car
    {
        private double _loadCapacity;


        public FreightCar(double length, double width, 
            double height, double weight, string color, double loadCapacity) : 
            base(length, width, height, weight, color)
        {
            _loadCapacity = loadCapacity;
        }
    }
}
