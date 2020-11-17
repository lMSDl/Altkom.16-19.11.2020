using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleBuilderFacade : VehicleBuilderBase
    {
        public VehicleBuilderFacade() : base(new Vehicle())
        {
        }

        public VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Components => new VehicleBuilder(Vehicle);
        public VehicleManufacturingBuilder Manufacturing => new VehicleManufacturingBuilder(Vehicle);
    }
}
