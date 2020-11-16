using System;

namespace WPCSharp.SOLID.L
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
    /*internal class Square : Rectangle
    {
        public override int A { get => base.A; set => base.A = base.B = value; }
        public override int B { get => base.B; set => base.A = base.B = value; }
    }

    internal class Rectangle : Shape
    {
        public virtual int A { get; set; }
        public virtual int B { get; set; }
        public override double Area => A * B;
    }*/
}
