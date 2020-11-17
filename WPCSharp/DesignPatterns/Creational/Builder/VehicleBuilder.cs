﻿namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleBuilder : VehicleBuilderFacade
    {
        public VehicleBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder SetDoors(int value)
        {
            Vehicle.Doors = value;
            return this;
        }

        public VehicleBuilder SetEnginePower(int value)
        {
            Vehicle.EnginePower = value;
            return this;
        }

        public VehicleBuilder SetSeats(int value)
        {
            Vehicle.Seats = value;
            return this;
        }

        public VehicleBuilder SetTrunkCapacity(int value)
        {
            Vehicle.TrunkCapacity = value;
            return this;
        }

        public VehicleBuilder SetWheels(int value)
        {
            Vehicle.Wheels = value;
            return this;
        }
    }
}
