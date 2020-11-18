using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.NullObject
{
    public class ConsoleOutput : Output
    {
        public override void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
