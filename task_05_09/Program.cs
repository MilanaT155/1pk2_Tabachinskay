namespace task_05_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Дан квадратный массив размерность n* n. Произведите анализ данной матрицы и выясните является ли данная матрица Z - матрицей
            //(это матрица, где все недиагональные элементы меньше нуля)
            //Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали.Если не выполняется, то
            //вывести сообщение что данная матрица не является Z - матрицей
            int n = 7;
            int[,] x = new int[n, n];
            Random rnd = new Random();
            Console.WriteLine("Матрица");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    x[i, j] = rnd.Next(-20, 20);
                    Console.Write(x[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            
            bool w = true;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && x[i, j] >= 0)
                    {
                        w = false;
                        break;
                    }


                }
                if (!w)
               break;
            }
            if (w)
            {
                Console.WriteLine("Данная матрица является Z-матрицей ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine(x[i, j] + "\t");

                        }
                        else
                        {
                            Console.WriteLine(x[i, j] + "\t");


                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Данная матрица не является Z-матрицей ");

            }
        }
    }
}
