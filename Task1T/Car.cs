using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1T
{
    class Car
    {
        private double _length;
        private double _width;
        private double _height;
        private double _weight;
        private string _color;

        public double Length { get => _length; set => _length = value; }
        public double Width { get => _width; set => _width = value; }
        public double Height { get => _height; set => _height = value; }
        public double Weight { get => _weight; set => _weight = value; }
        public string Color { get => _color; set => _color = value; }
    }
}
