using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(BoldText element);
        void Visit(PlainText element);
        void Visit(Hyperlink element);
    }
}
