namespace task_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Осуществить генерация двумерного[10 * 5] массива по следующему правилу:
            //• 1 столбец содержит нули
            //• 2 столбце содержит числа кратные 2
            //• 3 столбец содержит числа кратные 3
            //• 4 столбец содержит числа кратные 4
            //• 5 столбец содержит числа кратные 5
            //Осуществить переворот массива(поменять строки и столбцы местами) вывести обновленный массив
            int[,] x = new int[10, 5];
            int c = 1;
            Random rnd = new Random();
            int y = 1;
            for (int i = 0; i < x.GetLength(0); i++)
            {

                int z = rnd.Next(1, 30);
                x[i, 0] = 0;
                x[i, 1] = z * 2;
                x[i, 2] = z * 3;
                x[i, 3] = z * 4;
                x[i, 4] = z * 5;
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Обновленный массив");

            for (int j = 0; j < x.GetLength(1); j++)
            {
                for (int i = 0; i < x.GetLength(0); i++)
                {


                    Console.Write(x[i, j] + "\t");
                }
                Console.WriteLine();






            }
        }
    }
}
 


