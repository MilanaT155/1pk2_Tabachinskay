namespace task_14_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Реализуйте статический метод Factorial, который принимает целое число и 
            //возвращает его факториал.Сделайтетак, чтобы метод работал только для 
            //неотрицательных чисел.

        }
        static int Factorial(int x)
        {
            if (x > 0)
            {
                for (int i = 0; i < x; i++)
                {
                    return x * i;
                }
            }
            else
            {
                Console.WriteLine("Число отрицвтельное");
                return x;
            }
            return 0;
        
        }
    }
}
