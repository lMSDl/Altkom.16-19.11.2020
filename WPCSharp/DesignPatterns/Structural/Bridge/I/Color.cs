using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Bridge
{
    public abstract class Color
    {
        public abstract string ColorValue { get; }
        public Brightness Brightness { get; set; }

        public override string ToString()
        {
            return Brightness == null ? ColorValue : Brightness.Value + ColorValue;
        }
    }
}
