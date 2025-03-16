using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13_03
{
    internal class Car
    {
        public string number { set; get; }
        public string brand { set; get; }
        public string color { set; get; }
        public int speed { set; get; }
        public void ride()
        {
            for (int i = 0; i < 30; i += 5)
            {
                speed += i;
                if (speed > 60)
                {
                    Console.WriteLine("Скорость превыщена!!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Скрость равна: {speed} км/ч");
                }
            }


        }
        public void braking()
        {
            Console.WriteLine("Автомобиль остановлен");
            speed = 0;
        }
        public void Print()
        {
            Console.WriteLine($"Номер автомобиля: {number}");
            Console.WriteLine($"Бренд автомобиля: {brand}");
            Console.WriteLine($"Цвет автомобиля: {color}");
            Console.WriteLine($"Скорость автомобиля на данный момент: {speed} км/ч ");


        }
    }
}
