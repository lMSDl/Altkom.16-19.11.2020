using RefactorThis.GraphDiff;
using RepositoryDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.Services
{
    public class PeopleService : CRUDService<Person, long>
    {
        public IEnumerable<Person> ReadByFirstName(string firstName)
        {
                using (var context = new Context())
                {
                    return context.Set<Person>().Include(x => x.Address).Where(x => x.FirstName == firstName).ToList();
                }
        }
        public override long Create(Person entity)
        {
            entity.Id = 0;
            return CreateOrUpdate(entity);
        }
        public long CreateOrUpdate(Person entity)
        {
            using (var context = new Context())
            {
                entity = context.UpdateGraph(entity, mapping => mapping.AssociatedEntity(x => x.Address));
                context.SaveChanges();
            }
            return entity.Id;
        }

        public override void Update(Person entity)
        {
            CreateOrUpdate(entity);
        }
    }
}
