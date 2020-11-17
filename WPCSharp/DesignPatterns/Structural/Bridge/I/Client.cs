using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Bridge
{
    public class Client
    {
        public static void Execute()
        {
            var shape = new Circle();
            shape.Color = new RedColor();
            shape.Color.Brightness = new DarkBrightness();

            Console.WriteLine(shape);
        }
    }
}
