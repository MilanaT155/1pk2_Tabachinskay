namespace task_11_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Использование params и out: Напишите метод, который принимает переменное количество
//чисел и возвращает их сумму и максимальное значение через выходные параметры(out).
            int sum;
            int max;
            MatSumAndMax(out sum, out max, 1,  2, 3, 4, 5);

            Console.WriteLine($"Сумма: {sum}, Максимальное значение: {max}");
        }

       
        static void MatSumAndMax( out int sum, out int max, params int[] array)
        {
            sum = 0;
            max = 0 ; 

           
            if (array.Length == 0)
            {
                max = 0; 
                return;
            }

           
            foreach (var number in array)
            {
                sum += number; 
                if (number > max) 
                {
                    max = number;
                }
            }
        }
    }
}
    
