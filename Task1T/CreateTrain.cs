using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Task1T
{
    class CreateTrain
    {
        private List<Car> Train;

        public CreateTrain(Car car)
        {
            Train = new List<Car>() {car};
        }

        public bool Add(Car car)
        {
                if (Train[0] is Locomotive temp 
                    && temp.Traction >= TotalPlaceTrain() + car.TotalWeight()) // проверка на наличие локоматива и если да, то хватит ли тяги
                {
                    Train.Add(car);                 //если да, то добавляем в поезд
                    return true;
                }
                                                        //не добавляем
            return false;
        }

        public int TotalPlaceTrain()
        {
            int totalPlaces = 0;
            foreach (var i in Train.FindAll(x => x is PassengerCar))
            {
                totalPlaces += ((PassengerCar) i).NumberOfPlaces;
            }

            return totalPlaces;
        }

        public double TotalWeightTrain()
        {
            double trainWeight = 0;
            foreach (var i in Train)                   //считаем вес поезда 
            {
                trainWeight += i.TotalWeight();
            }

            return trainWeight;
        }
    }
}

