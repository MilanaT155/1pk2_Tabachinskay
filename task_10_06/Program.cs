namespace task_10_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать Метод ArrayGeneration 
            //    не возвращающий значения, принимает целое число n, выводит 
            //    наконсольсгенерированный массив размерности n* n.
            Console.WriteLine("Введите размерт n массива");

            int n = int.Parse(Console.ReadLine());
            
            ArrayGeneration(n);


        }
        static void ArrayGeneration(int x)
        {
            int[,] array = new int[x, x];
            Random random = new Random();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(array[i,j]
                    + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
