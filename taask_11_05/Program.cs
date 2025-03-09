namespace taask_11_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке(ref) и
            //возвращает их сумму и произведение через выходные параметры(out).
            int a = 5;
            int b = 10;

           
            int sum;
            int z;

            Mat(ref a,ref b, out sum, out z);

          
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {z}");
        }

        
        static void Mat(ref int x, ref int y, out int sum, out int z)
        {
            sum = x + y; 
            z = x * y; 

            
            x += 1; 
            y += 1;
        }
    }
}
    
