using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Adapter.II
{
    public class Client
    {
        public static void Execute()
        {
            var service = new DbPeopleService();
            var serviceAdapter = new DbPeopleServiceAdapter(service);
            foreach (var item in serviceAdapter.Get())
            {
                ToString(item);
            }

        }

        public static void ToString(IPerson person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
