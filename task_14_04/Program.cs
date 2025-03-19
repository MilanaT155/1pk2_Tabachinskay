namespace task_14_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определите класс User, который будет иметь статическое 
            //свойство CurrentUser, представляющее текущего пользователя, и метод для его установки.
            User.Info("Petia","Sidorov","Ivanofich", 105);
            Console.WriteLine(User.CurrentUser.name);

        }
    }
}
