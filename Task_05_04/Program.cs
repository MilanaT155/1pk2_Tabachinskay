namespace Task_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Дан квадратный массив размерность n* n. Произведите анализ данной матрицы и выясните является ли данная матрица
            //диагональной(все элементы вне главной диагонали равны нулю)
            //Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
            //сообщение что матрица не является диагональной.
            Console.Write("Введите значение n : ");
            int n = int.Parse(Console.ReadLine());

            
            int[,] x = new int[n, n];

            
            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    x[i, j] = int.Parse(Console.ReadLine());
                }
            }

           
            bool с = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j &&x[i, j] != 0) 
                    {
                        с = false;
                        break;
                    }
                }
                if (!с)
                    break;
            }

            
            if (с)
            {
                Console.WriteLine("Матрица является диагональной.");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(x[i, j] + "\t");

                        }
                        else
                        {
                            Console.Write(x[i, j] + "\t");
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("\nМатрица не является диагональной.");
            }
        }
    }
}
    

