using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Bridge.II
{
    public class MessageAbstraction
    {
        private IMessageImplementation implementation;

        public MessageAbstraction(IMessageImplementation implementation)
        {
            this.implementation = implementation;
        }

        public virtual void SendMessage(string message)
        {
            implementation.SendMessage(message);
        }
    }
}
