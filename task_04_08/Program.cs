namespace task_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения
            //которых равны
            int[] x = new int[50];
            Random rnd = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(0, 100);
                Console.WriteLine(x[i]);
            }
            int z = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (x[i] == x[j])
                    {
                        z++;

                    }

                }
            }
            Console.WriteLine($"Коллисество пар: {z}");
        }
    }
}
