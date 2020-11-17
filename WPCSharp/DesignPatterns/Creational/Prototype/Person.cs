using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPCSharp.DesignPatterns.Creational.Prototype
{
    public class Person : EditableObject<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Address> Address { get; set; } = new List<Address>();

        public override object Clone()
        {
            var clone = (Person)base.Clone();
            //clone.Address = new List<Address>(Address);
            clone.Address = Address.Select(x => x.Clone()).Cast<Address>().ToList();
            //clone.Address = (Address)Address.Clone();
            return clone;
        }

        protected override void Restore(Person clone)
        {
            Age = clone.Age;
            Name = clone.Name;
            Address = clone.Address;
        }
    }
}
