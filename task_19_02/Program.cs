namespace task_19_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Напишите программу, которая запрашивает у пользователя произвольный текст, содержащий
            //предложения(есть знаки препинания).программу после анализа выводит текст, разделенный на
            //части:
            //a)
            //По пробелам(отдельные слова построчно)
            //b)
            //По предложениям(отдельные предложения построчно)
            //(используйте метод Split())
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            string[] textArray = text.Split();
            foreach (String s in textArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Введите текст, сoстоящий из нескольких предложений: ");
            string text2 = Console.ReadLine();
            string[] text2Array = text2.Split(".");
            foreach (String s in text2Array)
            {
                Console.WriteLine(s);
            }


        }
    }
}
