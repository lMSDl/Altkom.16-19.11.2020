using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Bridge.II
{
    public interface IMessageImplementation
    {
        void SendMessage(string message);
    }
}
