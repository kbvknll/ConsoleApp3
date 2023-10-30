using ConsoleApp3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Transports
{
    class Car : Transport
    {
        public override float Speed { get; set; }

        public override void GoForward()
        {
            Console.WriteLine("Р-р-р-р-р  би-бип... Пора мне в дурку с этими машинками");
        }

        //Конструктор класса
        public Car(float speed, string color, string model, bool rent, string rigtsCategory, string motor, int numWheels)
        {
            Type = "Машина";
            Speed = speed;
            Color = color;
            Model = model;
            Rent = rent;
            RightsCategory = rigtsCategory;
            Motor = motor;
            NumWheels = numWheels;
        }
    }
}
