using Newtonsoft.Json;
using RepositoryDesignPattern.Models;
using RepositoryDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { FirstName = "Edward", LastName = "Edwardowski", BirthDate = DateTime.Now };
            var address = new Address() { City = "Łódź", Street = "Warszawska", Id = 2 };
            person.Address = address;



            //CreatePerson(person);
            //CreateAddress(address);

            new CRUDService<Address, int>().Update(address);

            new CRUDService<Address, int>().Read().ToList().ForEach(x => Console.WriteLine(JsonConvert.SerializeObject(x)));
            new PeopleService().Read().ToList().ForEach(x => Console.WriteLine(JsonConvert.SerializeObject(x)));
            new PeopleService().ReadByFirstName("Edward").ToList().ForEach(x => Console.WriteLine(JsonConvert.SerializeObject(x)));

            Console.ReadLine();
        }

        private static void CreateAddress(Address address)
        {
            using (var context = new Context())
            {
                context.Set<Address>().Add(address);
                context.SaveChanges();
            }
        }

        private static void CreatePerson(Person person)
        {
            new PeopleService().Create(person);
        }
    }
}
