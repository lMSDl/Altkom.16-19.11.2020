using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Creational.Flyweight
{
    public interface ICarFlyweight
    {
         string Manufacturer { get; set; }
         string Model { get; set; }
         string Color { get; set; }

        void Operation(Car car);
    }
}
