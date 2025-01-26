namespace task_04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран. То есть найти и
            //вывести уникальные элементы массива. 
            int[] x = new int[30];
            Random random = new Random();

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = random.Next(10, 50);
            }
            bool y = true;
            Console.WriteLine($"Уникльные элементы:");
            for (int i = 0; i <= x.Length; i++)
            {
                y = true;
                for (int j = 0; j < x.Length; j++)
                {
                    if (x[i] == x[j] && i != j)
                    {
                        y = false;

                    }
                }



                if (y == true)
                {
                    Console.WriteLine(x[i]);
                    ;
                }



            }
        }
    }
}
