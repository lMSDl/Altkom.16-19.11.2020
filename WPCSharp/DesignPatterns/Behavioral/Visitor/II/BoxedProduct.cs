using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Visitor.II
{
    public class BoxedProduct : Product
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public override void PrintType()
        {
            Console.WriteLine("BoxedProduct");
        }
    }
}
