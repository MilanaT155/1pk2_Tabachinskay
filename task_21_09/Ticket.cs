using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_21_09
{
    internal class Ticket
    {
        public int TicketNumber {  get; set; }
        public decimal Price { get; set; }
        public bool Baggage {  get; set; }
        public bool Discounted { get; set; }
        public Ticket (int ticketNumber, decimal price, bool baggage, bool discounted)
        {
            TicketNumber = ticketNumber;
            Price = price;
            Baggage = baggage;
            Discounted = discounted;


        }
      




    }
}
