using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public abstract class VehicleBuilderBase
    {
        protected Vehicle Vehicle { get; }

        public VehicleBuilderBase() : this(new Vehicle()) 
        {

        }
        public VehicleBuilderBase(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
        public Vehicle Build()
        {
            return Vehicle;
        }
    }
}
