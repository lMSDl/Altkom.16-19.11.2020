using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Creational.Flyweight
{
    public class CarFlyweight : ICarFlyweight
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void Operation(Car car)
        {
            var shared = JsonConvert.SerializeObject(this);
            var unique = JsonConvert.SerializeObject(car);

            System.Console.WriteLine($"{GetType().Name}: Shared: {shared}; Unique: {unique}");
        }
    }
}
