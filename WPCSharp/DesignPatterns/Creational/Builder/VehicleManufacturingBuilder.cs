using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleManufacturingBuilder : VehicleBuilderFacade
    {
        public VehicleManufacturingBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleManufacturingBuilder SetManufacturer(string value)
        {
            Vehicle.Manufacturer = value;
            return this;
        }
        public VehicleManufacturingBuilder SetModel(string value)
        {
            Vehicle.Model = value;
            return this;
        }
        public VehicleManufacturingBuilder SetProductionDate(DateTime value)
        {
            Vehicle.ProductionDate = value;
            return this;
        }
    }
}
