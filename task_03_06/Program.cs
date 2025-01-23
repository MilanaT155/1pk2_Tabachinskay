namespace task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥| для - 4≤x≤4, с шагом h = 0,5.
            Console.WriteLine("Таблица значений функции");
            for (double z = -4;z <= 4;z = z + 0.5)
            {
                double f = Math.Abs(z);
                Console.WriteLine($"{z} \t {f}");
            }
            Console.ReadKey();
        }
    }
}
