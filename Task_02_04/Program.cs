namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
         //Пользователь вводит свою дату рождения построчно(сначала год, потом месяц и в конце дату) произведите
        //расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
       //этом

        {
            Console.WriteLine("Введите нынешний год :\n");
                int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нынешний месяц :\n");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нынешний день:\n");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год своего рождения:\n");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц своего рождения:\n");

            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день своего рождения:\n");
            int c = Convert.ToInt32(Console.ReadLine());
           
            int f =y - a;
            if ((z < b & f == 18) || (z == b & m < c))
            { f -= 1; }
            Console.WriteLine(f);
            if (f >= 18)
            {
                Console.WriteLine("Совершеннолетний");
            }
            else {
                Console.WriteLine("Несовершеннолетний"); }

        }
    }
}
