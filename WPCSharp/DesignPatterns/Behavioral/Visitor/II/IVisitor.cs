using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Visitor.II
{
    public interface IVisitor
    {
        void Visit(Product product);
        void Visit(BoxedProduct product);
    }
}
