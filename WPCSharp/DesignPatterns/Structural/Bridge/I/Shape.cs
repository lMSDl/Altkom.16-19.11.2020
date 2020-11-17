using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Bridge
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public override string ToString()
        {
            return $"{Color}{GetType().Name}";
        }
    }
}
