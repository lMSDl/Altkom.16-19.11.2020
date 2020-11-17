using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Bridge.II
{
    public class EmailGate : IMessageImplementation
    {
        public void SendMessage(string message)
        {
                Console.WriteLine($"Wiadomość wsyłana przez email: {message}");
        }
    }
}
