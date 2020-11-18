using Newtonsoft.Json;
using System;

namespace WPCSharp.DesignPatterns.Behavioral.Memento
{
    public static class Client
    {
        public static void Execute()
        {
            Person person = new Person()
            {
                Name = "Adam Adamski",
                BirthDate = new DateTime(1989, 12, 12)
            };

            Caretaker<Person> caretaker = new Caretaker<Person>(person);
            Console.WriteLine(JsonConvert.SerializeObject(person));
            caretaker.Save();

            person.Name = "Ewa Ewowska";

            Console.WriteLine(JsonConvert.SerializeObject(person));
            caretaker.Save();

            person.BirthDate = DateTime.Now;

            Console.WriteLine(JsonConvert.SerializeObject(person));
            caretaker.Save();


            person.Name = "Ewa Adamska";
            Console.WriteLine(JsonConvert.SerializeObject(person));

            caretaker.ChangeState(x => x.Name.Contains("Adam"));
            Console.WriteLine(JsonConvert.SerializeObject(person));

            caretaker.Undo();
            Console.WriteLine(JsonConvert.SerializeObject(person));
            caretaker.Undo();
            Console.WriteLine(JsonConvert.SerializeObject(person));
            caretaker.Undo();
            Console.WriteLine(JsonConvert.SerializeObject(person));


        }
    }
}
