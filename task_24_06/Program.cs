using System.IO;

namespace task_24_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишите метод, который принимает путь 
            //к файлу и возвращает количество строк в нем. Используйте StreamReader.
            string file1 = "C:\\work\\Mil.txt";
            Console.WriteLine($"Колличество строк:{StringFile(file1)}");
        }
        static int StringFile(string file)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                int x = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    x++;

                }
                return x;
            }
        }


    }
}
