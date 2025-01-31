using System.Drawing;

namespace Task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Даны два массива, заполненные символами английского алфавита размером 3 * 3.Проверить, являются ли матрицы равными, если
            //да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
            //элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны. 
            char[,] x1 = new char[3, 3];
            char[,] x2 = new char[3, 3];
            Console.WriteLine("введите элементы 1 матрицы ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    x1[i, j] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("введите элементы 2 матрицы ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    x2[i, j] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            bool z = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (x1[i, j] != x2[i, j]) 
                    {
                        z = false;
                        break;
                    }
                }
                if (!z)
                    break;
            }
            if (z)
            {
                Console.WriteLine("Матрицы равны.");
            }
            else
            {
                Console.WriteLine("Матрицы не равны.");

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (x1[i, j] == x2[i, j]) 
                        {
                            Console.BackgroundColor = ConsoleColor.Green; 
                            Console.Write(x1[i, j] + "\t");
                           
                        }
                        else
                        {
                            Console.Write(x1[i, j] + "\t"); 
                        }
                        Console.BackgroundColor= ConsoleColor.Black;
                    }
                    Console.WriteLine();
                }

                 

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (x1[i, j] ==x2[i, j]) 
                        {
                            Console.BackgroundColor = ConsoleColor.Green; 
                            Console.Write(x2[i, j] + "\t");
                            
                        }
                        else
                        {
                            Console.Write(x2[i, j] + "\t"); 
                        }
                        Console.BackgroundColor= ConsoleColor.Black;
                    }
                    Console.WriteLine();
                }
            }
        }
    }


}
    

