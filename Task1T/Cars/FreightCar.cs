using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1T
{
    class FreightCar: Car
    {
        public double LoadCapacity { get; set; }


        public FreightCar(double length, double width, double height,
            double weight, string color, double loadCapacity) : 
            base(length, width, height, weight, color)
        {
            LoadCapacity = loadCapacity;
        }

        public override double TotalWeight()
        {
            return Weight + LoadCapacity;
        }
    }
}
