namespace task_06_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте метод, который на вход принимает одномерный массив и число для поиска, 
            //    верните индекс искомого элемента в массиве. Если элемента нет – верните индекс = -1
            Console.WriteLine("Введите число от 1 до 99 для поиска в массиве");
            int x = int.Parse(Console.ReadLine());
            int[] array = new int[4];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {

                    array[i] = random.Next(0, 100);
               
            }
            Mat(array, x);
            Console.WriteLine(Mat(array, x));
            
        }
           public static int Mat(int[]array2, int x2)
           {
            for (int i = 0;i < array2.GetLength(0); i++)
            {
                
                    if (array2[i]==x2)
                    {
                        return i ;
                    }
                   
                }
            return -1;
            }

            }

        }
   
