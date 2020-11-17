using System;
using System.Collections.Generic;
using System.Text;
using WPCSharp.DesignPatterns.Structural.Flyweight;

namespace WPCSharp.DesignPatterns.Structural.Flyweight
{
    public interface ICarFlyweight
    {
         string Manufacturer { get; set; }
         string Model { get; set; }
         string Color { get; set; }

        void Operation(Car car);
    }
}
