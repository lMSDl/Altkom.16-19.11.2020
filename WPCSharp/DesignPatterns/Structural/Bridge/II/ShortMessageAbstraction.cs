using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Bridge.II
{
    public class ShortMessageAbstraction : MessageAbstraction
    {
        public ShortMessageAbstraction(IMessageImplementation implementation) : base(implementation)
        {
        }

        public override void SendMessage(string message)
        {
            base.SendMessage(message.Substring(0, 10));
        }
    }
}
