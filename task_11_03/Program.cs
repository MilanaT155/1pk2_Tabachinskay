namespace task_11_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            Выходной параметр(out): Напишите метод, который принимает строку и возвращает через
            //выходной параметр количество гласных и согласных букв в этой строке


            Console.Write("Напишите строку:");
            string x = Console.ReadLine();


            Metod(x, out int a, out int b);
            Console.WriteLine($"Количество гласных: {a}");
            Console.WriteLine($"Количество согласных: {b}");
        }

        
        static void Metod(string x, out int aa, out int bb)
        {
            aa = 0;
            bb = 0;

           
            string a3= "аеёиоуыэюяАЕЁИОУЫЭЮЯ";


            foreach (char c in x)
            {
                if (char.IsLetter(c))
                {
                    if (a3.Contains(c)) 
                    {
                        aa++;
                    }
                    else 
                    {
                        bb++;
                    }
                }
            }
        }
    }
}
    
