﻿namespace task_03_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5.

            for (int x = 20; x <= 50; x++)
            {
                if ((x % 3 == 0) && (x % 5 != 0))
                {
                    Console.WriteLine(x);
                }
                
            }
        }
    }
}
