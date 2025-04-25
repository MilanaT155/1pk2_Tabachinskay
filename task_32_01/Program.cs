namespace task_32_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weather weather = new Weather();
            Kolobok kolobok = new Kolobok();
            List<Animal> animals = new List<Animal>
            {
             new Hare(),
             new Wolf(),
            new Bear(),
             new Fox()
             };
            foreach (var animal in animals)
            {
                Random random = new Random();
               int rand = random.Next(1, 4);
               
                
                if (!kolobok.IsAlive)
                    break;

                kolobok.Roll();
                kolobok.MeetAnimal(animal);
                if (rand == 1)
                {
                    weather.trables(kolobok); 
                }
            }
            if (kolobok.IsAlive)
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }

        }
    }
}
