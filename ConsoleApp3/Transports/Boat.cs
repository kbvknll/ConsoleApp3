using ConsoleApp3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Transports
{
    class Boat : Transport
    {
        public override float Speed { get; set; }

        public override void GoForward()
        {
            Console.WriteLine("Плюх аууу... Точно пора в дурку");
        }

        //Конструктор класса
        public Boat(float speed, string color, string model, bool rent, string rigtsCategory, string motor)
        {

            Type = "Лодка";
            Speed = speed;
            Color = color;
            Model = model;
            Rent = rent;
            RightsCategory = rigtsCategory;
            Motor = motor;
        }
    }
}
