using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Car
    {
        public string Model { get; set; }
        public string Number { get; set; }
        public Car() {}
        public Car(string model, string number)
        {
            Model = model;
            Number = number;
        }
        public virtual void Show() => Console.WriteLine($"Car: Model = {Model},Number = {Number}");
        
    }
    internal class Sedan: Car
    {

        int NumberOfPlaces;
        public Sedan(string Model, string Number, int NumberOFPlaces) : base(Model, Number)
        {
            NumberOfPlaces = NumberOFPlaces;
        }
        public override void Show() => Console.WriteLine($"Легковой автомобиль: Марка - {Model}, Номер - {Number}, Число пассажирских мест - {NumberOfPlaces}");
    }
    internal class Cargo: Car
    {
        int LoadCapacity;
        public Cargo(string Model, string Number, int LoadCapacity) : base(Model, Number)
        {
            this.LoadCapacity = LoadCapacity;
        }
        public override void Show() => Console.WriteLine($"Грузовой автомобиль: Марка - {Model}, Номер - {Number}, Грузоподъемность - {LoadCapacity}т");
    }
}   
