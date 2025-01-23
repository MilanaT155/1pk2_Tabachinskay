namespace task_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
         //Фаренгейта(F = C * 1, 8 + 32).Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
         //время работы программы

            Console.WriteLine("Введите первую температуру: "); 

            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую температуру: "); 
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите диапазон изменения температуры: "); 
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Цельсия     Фаренгейта ");
            
            
            do
            {
                double b = x * 1.8 + 32;
                Console.WriteLine($"{x} \t  {b}");
                double m = y + x;
            } while (x<= z);
            Console.ReadKey();
        }
    }
}
