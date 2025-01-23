namespace task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Написать программу, которая выводит таблицу скорости(через каждые 0, 5с) свободно падающего тела v = g t ,
            //где 2 g = 9,8 м / с2 – ускорение свободного падения.
            const double g = 9.8;
            double z = Convert.ToDouble(Console.ReadLine());
            for (double x = 0.5; x <= z; x = x + 0.5)
            {
                double y = g * x;
                Console.WriteLine($"{x} \t {y}");
            }
            Console.ReadKey();
        }
    }
}
