using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_20_03
{
    public enum OrderStatus
    {
        New,
        processing,
        Shipped,
        Delivered,
        cancelled
    }

    public class Order
    {
        public OrderStatus Status { get; private set; } = OrderStatus.New;

        public void ChangeStatus(OrderStatus NewStatus)
        {
            if (Status == OrderStatus.Delivered || Status == OrderStatus.cancelled)
            {
                Console.WriteLine($"нельзя сменить статус так как он уже {Status}");
                return;
            }

            Status = NewStatus;
            Console.WriteLine("статус переведен");
        }
    }
}
