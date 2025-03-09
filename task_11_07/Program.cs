namespace task_11_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Передача массива по ссылке(ref): Напишите метод, который принимает массив целых чисел по
//ссылке и изменяет его элементы, увеличивая каждый на 1.Проверьте, изменился ли
//оригинальный массив вне метода.
            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Оригинальный массив:");
            Print(array);

            
            x(ref array);

            Console.WriteLine("Измененный массив:");
            Print(array);
        }

       
        static void x(ref int[] array1)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] += 1; 
            }
        }

        
        static void Print(int[] array2)
        {
            for (int i = 0;i < array2.Length; i++)
            {
                Console.Write(array2[i]+"\t");
            }
            Console.WriteLine();
        }
    }
}
    
