using ConsoleApp3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Transports
{
    class Scooter : Transport
    {
        public override float Speed { get; set; }

        public override void GoForward()
        {
            Console.WriteLine("Вжух!!...");
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Скорость: {Speed},\n Цвет: {Color},\n Модель: {Model},\n " +
                $"Арендован: {(Rent ? "Да" : "Нет")},\n Мотор: {Motor}\n");
        }

        public Scooter(float speed, string color, string model, bool rent, int numWheels)
        {
            Type = "Самокат";
            Speed = speed;
            Color = color;
            Model = model;
            Rent = rent;
            NumWheels = numWheels;
        }
    }
}
