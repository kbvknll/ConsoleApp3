using ConsoleApp3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Transports
{
    class Bike : Transport
    {
        public override float Speed { get; set; }

        public override void GoForward()
        {
            Console.WriteLine("врваааауу.....");
        }

        //Конструктор класса
        public Bike(float speed, string color, string model, bool rent, string rigtsCategory, string motor, int numWheels)
        {
            Type = "Мотоцикл";
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
