namespace task_20_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Создайте программу для управления статусом заказа в интернет-магазине.Используйте перечислениеOrderStatus со значениями:
            //• New(новый)
            //• Processing(в обработке)
            //• Shipped(отправлен)
            //• Delivered(доставлен)
            //• Cancelled(отменён)
            //Напишите метод, который меняет статус заказа.Если заказ уже доставлен или отменён, запретите изменение статуса. Выводите сообщение при каждом изменении статуса(например,
            //"Заказ переведён в статус: Отправлен").
            Order order = new Order();

            order.ChangeStatus(OrderStatus.processing);
            order.ChangeStatus(OrderStatus.Shipped);
            order.ChangeStatus(OrderStatus.Delivered);
            order.ChangeStatus(OrderStatus.cancelled);
        }
    }
}
