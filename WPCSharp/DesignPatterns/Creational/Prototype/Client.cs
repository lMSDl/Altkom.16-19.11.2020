using Newtonsoft.Json;
using System;

namespace WPCSharp.DesignPatterns.Creational.Prototype
{
    public class Client
    {
        public static void Execute()
        {
            Person p1 = new Person
            {
                Age = 23,
                Name = "Adam Adamski"
            };
            p1.Address.Add(new Address { City = "Warszawa", Street = "Mazowiecka", PostCode = "00-111" });

            Display(p1);
            var p2 = (Person)p1.Clone();
            p2.Name = "Ewa Adamska";
            Display(p2);
            p1.Address[0].Street = "Krakowska";
            p2.Address.Add(new Address { City = "Kraków", Street = "Warszawska", PostCode = "31-111" });
            Display(p1);
            Display(p2);

            p2.StartEdit();
            p2.Address.Clear();
            p2.Age = 10;

            Display(p2);
            p2.CancelEdit();
            p2.StartEdit();
            p2.Name = "Ewa Ewowska";
            p2.FinishEdit();
            Display(p2);

        }

        private static void Display(Person person)
        {
            Console.WriteLine(JsonConvert.SerializeObject(person));
        }
    }
}
