namespace task_11_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //           Массив параметров(params): Напишите метод, который принимает массив чисел и возвращает
            //их среднее значение. Используйте ключевое слово params

            double x = C (1, 2, 3, 4, 5);
            Console.WriteLine($"Среднее значение: {x}");
        }

       
        static double C (params double[] numbers)
        {
           
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number; 
            }

            return sum/ numbers.Length; 
        }
    }

}
    
