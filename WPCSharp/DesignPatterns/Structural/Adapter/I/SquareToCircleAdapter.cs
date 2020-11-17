using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Adapter.I
{
    public class SquareToCircleAdapter : ICircle
    {
        private Square square;

        public SquareToCircleAdapter(Square square)
        {
            this.square = square;
        }

        public float Radius => square.Width * (float)Math.Sqrt(2) / 2f;
    }
}
