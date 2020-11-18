using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Button : Component
    {
        public Func<Component, bool> Func { get; set; }

        protected override void Click(bool handled)
        {
            Console.WriteLine("Button Click");
            if (!handled && !Func(Parent))
                base.Click(handled);
            else
                base.Click(true);
        }
    }
}
