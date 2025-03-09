namespace task_11_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Передача по ссылке(ref): Напишите метод, который принимает два целых числа по ссылке и
            //меняет их местами. Проверьте, изменились ли значения переменных вне метода
            int a = 5;
            int b = 10;

            Console.WriteLine($"До обмена: a = {a}, b = {b}");

            
            Swap(ref a, ref b);

            Console.WriteLine($"После обмена: a = {a}, b = {b}");
        }

       
        static void Swap(ref int x, ref int y)
        {
            int z= x; 
            x = y;        
            y = z;    
        }
    }
    }

