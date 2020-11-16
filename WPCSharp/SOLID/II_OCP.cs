using System;

namespace WPCSharp.SOLID.O
{
    internal abstract class Shape
    {
        public abstract double Area { get; }
    }

    internal class Square : Shape
    {
        public int A { get; set; }
        public override double Area => A * A;
    }

    internal class Rectangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
        public override double Area => A * B;
    }

    internal class Circle : Shape
    {
        public int R { get; set; }
        public override double Area => Math.PI * R * R;
    }

    internal class ShapeCalculator
    {
        private double Area(Shape shape)
        {
            return shape.Area;
        }
    }
}
