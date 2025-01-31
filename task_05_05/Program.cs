using System;

namespace task_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе[n * m].Заполнение
            //случайными числами в диапазоне от - 99 до 99 включительно.Осуществите без создания нового массива преобразование текущего
            //по следующему правилу:
            //• Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
            //• Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом
            Console.WriteLine("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение m: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------");
            int[,] c = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    c[i, j] = rnd.Next(-99, 100);
                    if (c[i, j] < 0)
                    {
                        c[i, j] = Math.Abs(c[i, j]);
                        Console.BackgroundColor = ConsoleColor.Green;

                    }
                    else if (c[i, j] == 0)
                    {
                        c[i, j] = 1;
                        Console.BackgroundColor = ConsoleColor.Red;

                    }
                    
                   
                    Console.Write(c[i,j]+ "\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    

                }
                Console.WriteLine();
            }
            
        }  
    }
}

