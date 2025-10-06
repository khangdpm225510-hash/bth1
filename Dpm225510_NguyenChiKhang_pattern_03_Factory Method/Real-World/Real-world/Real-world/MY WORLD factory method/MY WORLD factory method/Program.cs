using System;

namespace MY_WORLD_factory_method
{
    class Program
    {
        static void Main()
        {
            VehicleFactory[] factories = new VehicleFactory[]
            {
                new CarFactory(),
                new BikeFactory(),
                new TruckFactory()
            };

            foreach (var factory in factories)
            {
                factory.Vehicle.ShowFeatures();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}