using System;

namespace WPCSharp.SOLID.L
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Move();
    }

    public class Airplane : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("I am flying!");
        }
    }

    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("I am driving!");
        }
    }
    /*public abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Fly();
        public abstract void Drive();
    }

    public class Airplane : Vehicle
    {
        public override void Fly()
        {
            Console.WriteLine("I am flying!");
        }

        public override void Drive()
        {
            throw new NotImplementedException();
        }
    }

    public class Car : Vehicle
    {
        public override void Fly()
        {
            throw new NotSupportedException();
        }

        public override void Drive()
        {
            Console.WriteLine("I am driving!");
        }
    }*/
}
