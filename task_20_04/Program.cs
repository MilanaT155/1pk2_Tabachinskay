using System.Diagnostics;

namespace task_20_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
            //• Car
            //• Bike
            //• Bus
            //• Truck
            //• Motorcycle
            //Храните список транспортных средств(можно просто List<VehicleType>).
            //                Добавьте метод для подсчёта транспорта 
            //                определённого типа(например, сколько грузовиков).
            //                Реализуйте поиск по типу и вывод информации.
            Transportation transportation = new Transportation();
            transportation.AddTransportation(VehicleType.Car);
            transportation.AddTransportation(VehicleType.Bike);
            transportation.AddTransportation(VehicleType.Bus);
            transportation.AddTransportation(VehicleType.Truck);
            transportation.AddTransportation(VehicleType.Motorcycle);
            Console.WriteLine(transportation.ReckonTransportation(VehicleType.Car));
            transportation.Search();





        }

    }
}
