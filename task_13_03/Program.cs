namespace task_13_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            создайте класс автомобиля
//свойства:
//номер авто, марка, цвет, текущая скорость
//методы:
//езда(симитировать равномерное ускорение скорости автомобиля)
//торможение(при превышении скорости автомобиля свыше допустимой - он должен остановиться)
//конструторы
//предусмотрите разные варианты инициализации объектов
         Car car = new Car();
            car.number = "А123ВГ";
            car.brand ="Tayota";
            car.color = "Черный";
            car.speed = 25;
            car.Print ();
            Console.WriteLine();
            car.ride();
            Console.WriteLine();
            car.braking();
                

        }
    }
}
