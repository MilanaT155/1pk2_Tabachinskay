namespace task_05_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Даны два массива размером 10 * 10, заполненные целыми числами в диапазоне от 1 до 9 вкл.Создать новый массив, который будет
            //произведением двух предыдущих(перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
            //результирующий массив)
            //Вывести результирующий массив
            int[,] x1 = new int[10, 10];
            int[,] x2 = new int[10, 10];
            int[,] c = new int[10, 10];
            Random rnd = new Random();
            Console.WriteLine("Первый массив:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x1[i, j] = rnd.Next(1, 10);
                    Console.Write(x1[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Второй массив:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x2[i, j] = rnd.Next(1, 10);
                    Console.Write(x2[i, j]+"\t");
                }
                Console.WriteLine();
            }
            for (int i = 0;i < 10; i++)
            {
                for (int j = 0;j < 10; j++)
                {
                    c[i,j] = x1[i, j] * x2[i,j];
                }
            }
            Console.WriteLine("результающий массив: ");
            for (int i = 0; i<10 ; i++)
            {
                for (int j = 0; j<10 ; j++)
                {
                    Console.Write(c[i, j]+"\t");
                }
                Console.WriteLine();
            }


        }
    }
}
