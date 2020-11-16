using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleInfoBuilder : IVehicleBuilder
    {
        private string _info = "Obiekt ma: ";

        public IVehicleBuilder SetDoors(int value)
        {
            _info += $"{value} drzwi,";
            return this;
        }

        public IVehicleBuilder SetEnginePower(int value)
        {
            _info += $"silnik o mocy {value}HP,";
            return this;
        }

        public IVehicleBuilder SetSeats(int value)
        {
            _info += $"{value} siedzeń,";
            return this;
        }

        public IVehicleBuilder SetTrunkCapacity(int value)
        {
            _info += $"{value}l pojemności bagażnika,";
            return this;
        }

        public IVehicleBuilder SetWheels(int value)
        {
            _info += $"{value} kół,";
            return this;
        }

        public string Build()
        {
            return _info.Remove(_info.Length - 1).Replace(",", ", ") + ".";
        }
    }
}
