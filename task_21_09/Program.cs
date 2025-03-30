using System.Net.Sockets;

namespace task_21_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            создайте класс билета(Ticket).сгенерируйте список из 30 билетов.произведите:
            //• поиск билета с максимальной суммой,
            //• билета с минимальной суммой,
            //• выведите список билетов с багажом
            //• выведите список люготных билетов
            List<Ticket> tickets = GenerateTickets(30);
   
            var maxTicket = tickets.OrderByDescending(t => t.Price).First();
            Console.WriteLine("Билет с максимальной ценой:");
            Console.WriteLine(maxTicket);

           
            var minTicket = tickets.OrderBy(t => t.Price).First();
            Console.WriteLine("\nБилет с минимальной ценой:");
            Console.WriteLine(minTicket);

         
            var ticketsWithBaggage = tickets.Where(t => t.Baggage).ToList();
            Console.WriteLine("\nСписок билетов с багажом:");
            foreach (var ticket in ticketsWithBaggage)
            {
                Console.WriteLine(ticket);
            }

         
            var discountedTickets = tickets.Where(t => t.Discounted).ToList();
            Console.WriteLine("\nСписок льготных билетов:");
            foreach (var ticket in discountedTickets)
            {
                Console.WriteLine(ticket);
            }
        }
        public static List<Ticket> GenerateTickets(int count)
        {
            Random random = new Random();
            List<Ticket> tickets = new List<Ticket>();

            for (int i = 1; i <= count; i++)
            {
                decimal price = Math.Round((decimal)(random.NextDouble() * 100), 2);
                bool hasBaggage = random.Next(2) == 0;
                bool isDiscounted = random.Next(2) == 0;

                tickets.Add(new Ticket(i, price, hasBaggage, isDiscounted));
            }

            return tickets;
        }



    }
}
    