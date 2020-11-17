using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace WPCSharp.DesignPatterns.Structural.Facade.III
{
    public interface IXmlConverter
    {
        XDocument ToXml();
    }
}
