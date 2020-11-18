using System;
using System.Collections.Generic;
using System.Linq;

namespace WPCSharp.DesignPatterns.Behavioral.Memento
{
    public class Person : ICloneable, IRestorable<Person>
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Restore(Person state)
        {
            var propertyInfos = GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                .Where(x => x.CanRead && x.CanWrite).ToList();

            propertyInfos.ForEach(x =>
            {
                var oldValue = x.GetValue(state);
                x.SetValue(this, oldValue);
            });
        }
    }
}
