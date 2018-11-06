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
    class TrainBuilder
    {
        private List<Car> Train;

        public TrainBuilder(Car car)
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

        public double TotalLoadCapacityTrain()                  // считаем багаж
        {
            double totalLoadCapacity = 0;
            foreach (var i in Train.FindAll(x => x is PassengerCar))
            {
                totalLoadCapacity += ((PassengerCar)i).NumberOfPlaces;
            }

            return totalLoadCapacity;

        }

        public List<PassengerCar> FindAllCarsByPlaces(int start, int over)     // поиск по кол-во пассажиров в заданом промежутке
        {
            List<PassengerCar> FoundCars = new List<PassengerCar>();                                //создаем список в котором будет все вагоны
                                                                                                    //удовлетворяющие параметру
            foreach (var i in Train.FindAll(x => x is PassengerCar))
            {
                if (((PassengerCar) i).NumberOfPlaces > start && ((PassengerCar) i).NumberOfPlaces < over)
                {
                    FoundCars.Add((PassengerCar)i);
                }
            }

            return FoundCars;
        }

        public void SortComfort()
        {
            var temp = Train.FindAll(x => x is PassengerCar).Cast<PassengerCar>();    //поиск всех пассажирских вагон
            temp = temp.OrderBy(e => e.Comfort);   //сортировка

            foreach (var x in temp)             //удаление всех пассажирских вагонов чтобы потом добавить отсортированный список
            {
                Train.Remove(x);
            }
            Train.AddRange(temp);
        }
    }
}

