using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1T
{
    public class Car
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public Car(double length, double width, double height, double weight, string color)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
            Color = color;
        }

        public virtual double TotalWeight()    // метод для высчитывания общей массы вагона, нужен в наследуемых классах
        {
            return Weight;
        }

}

}
