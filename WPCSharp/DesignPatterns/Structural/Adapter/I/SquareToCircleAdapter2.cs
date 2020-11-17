using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Adapter.I
{
    public class SquareToCircleAdapter2 : Square, ICircle
    {
        public float Radius => Width * (float)Math.Sqrt(2) / 2f;
    }
}
