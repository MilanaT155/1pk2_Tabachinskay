using System.Collections.Generic;

namespace task_21_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //напишите метод, который
            //на вход получается массив параметров(строк) и возвращает только уникальные строки
            string[] array = { "Милана", "Петя", "Вова", "Милана" };

           string[] uniqueString =  UniqueString(array);
            foreach (var item in uniqueString)
            {
                Console.WriteLine(item);
            }



        }
        static string[] UniqueString(string[] array)
        {
            SortedSet<string> set = new SortedSet<string>(array);
            return set.ToArray();

        }
    }
}
