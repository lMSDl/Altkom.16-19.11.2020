using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Decorator
{
    public interface INotification
    {
        void Send(string message);
    }
}
