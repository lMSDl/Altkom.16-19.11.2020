using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Composite
{
    public abstract class BaseProduct : IComponent
    {
        public string Name { get; }

        public BaseProduct(string name)
        {
            Name = name;
        }

        public abstract float GetPrice();
    }
}
