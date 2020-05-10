using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y=");
            float y = float.Parse(Console.ReadLine());
            if ((x > 10 || x < 0) || (y > 5 || y < 0))
                Console.WriteLine("Вне");
            else if ((x < 10 && x > 0) && (y < 5 && y > 0))
                Console.WriteLine("Внутри");
            else
                Console.WriteLine("На границе");

            //========================Задание2.2==========================//

            Console.Write("Введите признак: ");
            string i = Console.ReadLine();
            if (i == "а") Console.WriteLine("Максимальная скорость автомобиля = 228 км/ч");
            else if (i == "в") Console.WriteLine("Максимальная скорость велосипеда = 50 км/ч");
            else if (i == "м") Console.WriteLine("Максимальная скорость мотоцикла = 402 км/ч");
            else if (i == "с") Console.WriteLine("Максимальная скорость самолета = 8200,8 км/ч");
            else if (i == "п") Console.WriteLine("Максимальная скорость поезда = 581 км/ч");
            else 
                Console.WriteLine("Такого признака нет!");

            Console.ReadKey();
        }
    }
}
