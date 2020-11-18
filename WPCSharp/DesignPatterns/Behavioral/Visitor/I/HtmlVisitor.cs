using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Visitor
{
    public class HtmlVisitor : IVisitor
    {
        public string Output { get; set; }

        public void Visit(BoldText element)
        {
            Output += $"<b>{element.Bold}</b>";
        }

        public void Visit(PlainText element)
        {
            Output += element.Plain;
        }

        public void Visit(Hyperlink element)
        {
            Output += $"<a href=\"{element.Url}\">{element.Label}</a>";
        }
    }
}
