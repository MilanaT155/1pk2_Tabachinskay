using System.Reflection.Metadata.Ecma335;

namespace task_11_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Передача по значению: Напишите метод, который принимает два целых числа и меняет их
            //местами.Проверьте, изменились ли значения переменных вне метода
            int a = 5;
            int b = 10;

            

           
            Swap ( a, b);
            Console.WriteLine($"Вне метода: a = {a}, b = {b}");

        }

       
        static void Swap( int x, int y)
        {
            int z = x;
            x = y;
            y = z;
            Console.WriteLine($"Внутри метода: a = {x}, b = {y}");
        }
        
    }

    }

