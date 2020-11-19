using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.Models
{
    public class Address : Entity<int>
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
}
