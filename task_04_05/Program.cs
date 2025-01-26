namespace task_04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            В массиве хранятся сведения о количестве осадков за месяц(30 дней).Необходимо определить общее
            //количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и
            //отдельно вывести дни без осадков.Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет
            //осадков, до 300 мм выпавших осадков.

            //выводим колличество осадков за месяц
            int[] x = new int[30];
            Random rnd = new Random();

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(0, 301);
            }
            Console.WriteLine("Колличество осадков за месяц: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"День {i + 1}: {x[i]}");
            }
            //определяем колличество осадков за декаду 
            for (int decada = 0; decada < 3; decada++)
            {
                int y = decada * 10;
                int u = 0;
                for (int day = y; day < y + 10; day++)
                { u += x[day]; }
                Console.WriteLine($"Oбщее количество осадков {decada + 1}: {u}");
            }
            //определяем день с наибольшим колличеством осдков 
            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < x.Length; ++i)
            {
                max1 = x[i];
                max2 = i + 1;
            }
            Console.WriteLine($"День с самым сильным колличеством осадков: День {max2} {max1} мм");
            //определяем дни без осадков 
            Console.WriteLine("Дни без осадков: ");
            for (int i = 0; i < x.Length; ++i)
            {
                if (x[i] == 0)
                {
                    Console.WriteLine($"День {i + 1}");

                }





            }
        }
    }
    }

