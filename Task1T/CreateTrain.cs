using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
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
            double trainWeight = car.TotalWeight();    //считаем вес нового вагона
            foreach (var i in Train)                   //считаем вес поезда 
            {
                trainWeight += i.TotalWeight();
            }
                if (Train[0] is Locomotive temp && temp.Traction >= trainWeight) // проверка на наличие локоматива и если да, то хватит ли тяги
                {
                    Train.Add(car);                 //если да, то добавляем в поезд
                    return true;
                }
                                                        //не добавляем
            return false;
        }
    }
}

