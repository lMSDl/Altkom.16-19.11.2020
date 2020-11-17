using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Adapter.II
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
