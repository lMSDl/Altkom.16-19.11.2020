using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Visitor.II
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
