using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.AbstractClasses
{
    abstract class Transport
    {
        public string Type { get; set; }
        public abstract float Speed { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public bool Rent { get; set; } //Rent - Аренда. Арендован транспорт или нет?
        public virtual string RightsCategory { get; set; } //Создание свойства "Категория прав"
        public virtual string Motor { get; set; }

        //Количество колес, есть не у всех, поэтому виртуальное свойство
        public virtual int NumWheels { get; set; } 




        public abstract void GoForward();

        //Виртуальый метод для вывода информации, который может быть переделан для другого наследуемого класса
        public virtual void GetInfo() 
        {
            Console.WriteLine($"Скорость: {Speed},\n Цвет: {Color},\n Модель: {Model},\n " +
                $"Арендован: {(Rent? "Да" : "Нет")},\n Категория прав: {RightsCategory},\n Мотор: {Motor}\n");
        }
    }
}
