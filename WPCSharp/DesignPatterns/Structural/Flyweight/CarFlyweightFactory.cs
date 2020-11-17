using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;

namespace WPCSharp.DesignPatterns.Structural.Flyweight
{
    public class CarFlyweightFactory
    {
        private Dictionary<string, ICarFlyweight> Flyweights { get; }

        public CarFlyweightFactory(IEnumerable<ICarFlyweight> carFlyweights)
        {
            Flyweights = carFlyweights.ToDictionary(x => GenerateKey(x));
        }

        private string GenerateKey(ICarFlyweight carFlyweight)
        {
            var elements = new string[]
            {
                carFlyweight.Manufacturer,
                carFlyweight.Model,
                carFlyweight.Color
            };

            return string.Join("_", elements);
        }

        public ICarFlyweight GetFlyweight(ICarFlyweight carFlyweight)
        {
            var key = GenerateKey(carFlyweight);

            if(Flyweights.ContainsKey(key))
            {
                Console.WriteLine($"Uzywamy istniejącego elementu ({key})");
                return Flyweights[key];
            }

            Console.WriteLine($"Tworzymy nowy element ({key})");
            Flyweights.Add(key, carFlyweight);
            return carFlyweight;
        }

        public void List()
        {
            Console.WriteLine($"{GetType().Name}: Posiadamy {Flyweights.Count} elementów:");
            Flyweights.ToList().ForEach(x => Console.WriteLine(x.Key));
        }
    }
}
