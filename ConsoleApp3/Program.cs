using ConsoleApp3.Transports;
using System;
using ConsoleApp3.AbstractClasses;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace ConsoleApp3
  
{
    class Program 
    { 
        static void Main(string[] args)
        {

            List<Transport> ListTransport = new List<Transport>()
            {
                new Car(10f, "Green", "УАЗ 2107", false, "В", "Большой мотор", 4),
                new Car(20f, "Dark purple", "BMW X5", false, "В", "Большой мотор", 4),
                new Bicycle(1f, "Blue", "Navigator 700 MD", false, 2),
                new Bike(23f, "Red", "BMW 283", false, "А", "Средний мотор", 2),
                new Boat(8.5f, "White", "Marlin MP30", false, "А", "мотор лодочный"),
                new Scooter(5f, "Yellow", "CITYCOCO GT X3 PRO", false, 2)
            };

            int Number = 0;
            Transport transport = null;
            
            Console.Write("Выберите транспорт (введите цифру): лодка(1), машина(2), мотоцикл(3), велосипед(4), самокат(5), выйти(6)  << ");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (Number == 6)
                Environment.Exit(0);
            Console.WriteLine("Список транспорта: ");
            foreach(Transport item in ListTransport)
            {
                if (Number == 1 && item.Type == "Лодка")
                    Console.WriteLine($"{item.Model}");
                else if (Number == 2 && item.Type == "Машина")
                    Console.WriteLine($"{item.Model}");
                else if (Number == 3 && item.Type == "Мотоцикл")
                    Console.WriteLine($"{item.Model}");
                else if (Number == 4 && item.Type == "Велосипед")
                    Console.WriteLine($"{item.Model}");
                else if (Number == 5 && item.Type == "Самокат")
                    Console.WriteLine($"{item.Model}");
            }
            Console.WriteLine();
            Console.Write("Выбирите модель транспорта (напишите название модели): ");
            string NameModel = Console.ReadLine();
            foreach(Transport item in ListTransport)
            {
                if (item.Model.ToLower() == NameModel.ToLower())
                    transport = item;
            }

            Console.WriteLine();
            Console.WriteLine("Какое действие выполнить: Поехать вперед(1) / Забронировать(2) / Получить инфорацию(3)   << ");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch(Number)
            {
                case 1:
                    transport.GoForward();
                    break;
                case 2:
                    transport.Rent = true;
                    break;
                case 3:
                    transport.GetInfo();
                    break;
            }
        }
    }
}