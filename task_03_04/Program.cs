namespace task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается.Когда
            // пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
            //введенных пользователем.
            Console.WriteLine("Введите текст:");
            
            
            int z = 0;

            while (true) 
              {
                string x = Console.ReadLine();
                Console.Clear();
                

                if (x == "exit" || x == "") { break; }
                z++;
            }
            Console.WriteLine($"Колличество строк : {z}");
            
        }
    }
}
