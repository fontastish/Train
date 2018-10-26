using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1T
{
    class Locomotive : Car
    {
        private string _typeEngine;
        private double _maxSpeed;
        private double _consumption;
        private double _traction;

        public string TypeEngine { get => _typeEngine; set => _typeEngine = value; }
        public double MaxSpeed { get => _maxSpeed; set => _maxSpeed = value; }
        public double Consumption { get => _consumption; set => _consumption = value; }
        public double Traction { get => _traction; set => _traction = value; }

        public Locomotive(double length, double width, double height, double weight, string color,
            string typeEngine, double maxSpeed, double consumption, double traction) :
            base(length, width, height, weight, color)
        {
            _typeEngine = typeEngine;
            _maxSpeed = maxSpeed;
            _consumption = consumption;
            _traction = traction;
        }
    }
}
