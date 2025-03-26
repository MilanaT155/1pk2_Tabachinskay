using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_20_04
{
    public enum VehicleType
    {
        Car,
        Bike,
        Bus,
        Truck,
        Motorcycle

    }
    internal class Transportation
    {
        List<VehicleType> Vehicle = new List<VehicleType>();
        public VehicleType Afto {  get; private set; } = VehicleType.Car;
        public void AddTransportation(VehicleType type)
        {
            Vehicle.Add(type);
            Console.WriteLine($"{type} добавлена в список");
        }
        public int ReckonTransportation(VehicleType type)
        {
         return Vehicle.Count(v=>v==type);
        }
        public void Search()
        {
            foreach (VehicleType type in Vehicle)
            {
                Console.WriteLine(type.ToString());
            }
        }

    }
}
