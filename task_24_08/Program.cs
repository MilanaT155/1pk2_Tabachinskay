namespace task_24_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //реализуйте функцию, осуществляющую 
            // поиск текста в файле и его замену на значения, введенные пользователем
            string file = "C:\\work\\Task.txt";
            Console.Write("Введите слово для поиска: ");
           string word1=  Console.ReadLine();
            Console.Write("Введите слово для замены: ");
            string word2 = Console.ReadLine();
            ReplaceWord(file, word1, word2);
        }
        static void ReplaceWord(string file, string word1, string word2)
        {
          
                string content = File.ReadAllText(file);
                string content2 = content.Replace(word1, word2);
                File.WriteAllText(file, content2);
                Console.WriteLine("Замена завершена");
          
        }

    }
}
