using RepositoryDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.Services
{
    public class PeopleService : CRUDService<Person, long>
    {
        public IEnumerable<Person> ReadByFirstName(string firstName)
        {
                using (var context = new Context())
                {
                    return context.Set<Person>().Where(x => x.FirstName == firstName).ToList();
                }
        }
    }
}
