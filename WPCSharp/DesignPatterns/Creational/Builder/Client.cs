using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class Client
    {
        public static void Execute()
        {
            //var vehicle = new Vehicle(4, 5, 4, 500, 100);

            var vehicleBuilder = new VehicleInfoBuilder();
            vehicleBuilder
                .SetWheels(4)
                .SetSeats(5)
                .SetDoors(4)
                .SetTrunkCapacity(500)
                .SetEnginePower(100);

            Console.WriteLine(vehicleBuilder.Build());
        }
    }
}
