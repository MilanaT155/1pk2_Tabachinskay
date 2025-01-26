namespace task_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
            //отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
            //мальчиков и девочек. При выводе избавиться от отрицательных значений.
            int[] x = new int[30];
            Random rnd = new Random();
            int z = 0;
            int a = 0;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < x.Length; i++)
            {

                x[i] = rnd.Next(-300, 190);




                if (x[i] < 0)
                {
                    Console.WriteLine($"Рост мальчика {i} :");
                    Console.WriteLine(Math.Abs(x[i]));
                    sum1 += Math.Abs(x[i]);

                    z++;
                }



                else
                {
                    Console.WriteLine($"Рост девочки {i} :");
                    Console.WriteLine(x[i]);
                    sum2 += x[i];
                    a++;
                }
            }
            Console.WriteLine($"Колличество мальчиков:{z}");
            Console.WriteLine($"Колличество Девочек:{a}");
            Console.WriteLine("Средний рост мальчиков:  ");
            Console.WriteLine(sum1 / z);
            Console.WriteLine("Средний рост девочек:  ");
            Console.WriteLine(sum2 / a);




        }
    }

        }
    

