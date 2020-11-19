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
            var person = new Person() { FirstName = "Ewa", LastName = "Ewowska", BirthDate = DateTime.Now };
            var address = new Address() { City = "Warszawa", Street = "Mazowiecka" };



            //CreatePerson(person);
            //CreateAddress(address);


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
