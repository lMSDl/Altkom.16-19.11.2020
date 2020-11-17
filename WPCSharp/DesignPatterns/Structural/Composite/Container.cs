using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Composite
{
    public class Container : BaseProduct
    {
        private readonly ICollection<BaseProduct> _content;

        public Container(string name) : base(name)
        {
            _content = new List<BaseProduct>();
        }

        public void Add(BaseProduct product)
        {
            _content.Add(product);
        }

        public override float GetPrice()
        {
            var price = _content.Sum(x => x.GetPrice());
            Console.WriteLine($"Wartość kontenera {Name} to: {price}");
            return price;
        }
    }
}
