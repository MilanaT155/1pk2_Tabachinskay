namespace task_10_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте метод с помощью которого можно сгенерировать и вернуть 
            //    символьный двумерныймассив(состоящийиз символов русского алфавита) 
            //    и выведите на консоль данный массив с помощью другого метода
            //    (который принимает данный массив в качестве параметра)


            char[,] array = new char[3,3];
            array = Generate(array);
            Generate(array);
            Print(array);
        }
    
        static char[,] Generate(char [,] array)
        {
          
            Random rnd = new Random();
            char[,] array2 = new char[3, 3];
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                   
                    array2[i,j] = (char)rnd.Next(1040,1103);
                }
            }
            return array2;

        }

        static void Print(char[,] array2)
        {
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
