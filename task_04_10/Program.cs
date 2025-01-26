namespace task_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Заполнить массив из 10 элементов случайными числами в интервале[-10..10] и сделать реверс элементов
            //отдельно для 1 - ой и 2 - ой половин массива. Реверс реализовать через цикл. Стандартные методы класса Array
            //использовать нельзя.
            //Например, исходный массив: [5, 2, -10, 0, 4, -6, 7, 2, 9, -7]
            //Результат: [4, 0, -10, 2, 5, -7, 9, 2, 7, -6]
            int[] x = new int[10];
            Random rnd = new Random();
            Console.WriteLine("исходный массив : ");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(-10, 11);

                Console.WriteLine(x[i]);
            }
            Console.WriteLine("Результат:");
            int y1 = x.Length / 2;
            for (int i = y1; i >= 0; i--)
            {
                Console.WriteLine(x[i]);
            }

            for (int j = 9; j >= 5; j--)
            {
                Console.WriteLine(x[j]);

            }
        }
    }
}
