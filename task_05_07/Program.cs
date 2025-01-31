namespace task_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе[n * n].Заполнение случайными
            //числами в диапазоне от 10 до 99 включительно.
            //Найти и вывести отдельно минимальный элемент в матрице(LINQ под запретом) Осуществить умножение матрицы на ее
            //минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве
            Console.WriteLine("введите значение n");
            int n = int.Parse(Console.ReadLine());
            int[,] x = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    x[i, j] = rnd.Next(10, 100);
                }
            }
            int min = x[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (x[i, j] < min)
                    {
                        min = x[i, j];
                        
                    }


                }
            }
            Console.WriteLine($"Минимальный элемент {min}");
            int[,] z = new int[n,n];
            for (int i = 0;i < n; i++)
            {
                for(int j = 0; j< n; j++)
                {
                    z[i,j]= min * x[i, j];
                }
            }
            
            
            int[] max = new int[5];
            for (int i = 0; i<n; i++)
            {
                for ( int j = 0; j < n;j++)
                {
                    for (int k = 0; k < n;k++)
                    {
                        if ( z[i, j] > max[k] )
                        {
                            for (int  l = max.Length-1; l > k; l--)
                            {
                                max[l] = max[l-1];

                            }
                            max[k]=z [i, j];
                        }
                    }
                }
            }
            bool y = false;
            Console.WriteLine("Умноженная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int m = 0; m < n; m++)
                    {


                        if (z[i, j] == max[m])
                        {
                            y = true;
                            break;
                        }
                    }

                    if (y)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(z[i, j] + "\t");
                    }
                   
                    else
                    {
                        Console.Write(z[i, j] + "\t");

                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                
                Console.WriteLine();
            }
        }
    }
}
