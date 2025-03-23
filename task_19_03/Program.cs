using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;

namespace task_19_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Напишите консольное приложение, в котором осуществляется построчный пользовательский
            //ввод(ввод каждой строки подтверждается нажатием на enter).количество введенных строк
            //произвольно, ввод завершается при вводе пустой строки.
            //После окончания ввода произведите объединение всех ранеее введенных строк в одну с
            //использованием разделителя «-»
            //Например:
            //            Введите строку 1: "Hello"
            //Введите строку 2: "world"
            //Введите строку 3: "C#"
            //Результат: "Hello-world-C#"
            string text;
            string result= "";
            Console.WriteLine("Введите строки: ");
            while (true)
            {
                text = Console.ReadLine();
                if (text == "")
                {
                    break;
                }
                else
                {
                    result += " ";

                }
                result += text;
            }
            text = String.Join("-", result.Split(' '));
            Console.WriteLine($"Результат: {text} ");




        }
    }
}
