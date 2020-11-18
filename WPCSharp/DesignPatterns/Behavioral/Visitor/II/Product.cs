using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Visitor.II
{
    public class Product : IElement
    {
        public virtual void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public virtual void PrintType()
        {
            Console.WriteLine("Product");
        }
    }
}
