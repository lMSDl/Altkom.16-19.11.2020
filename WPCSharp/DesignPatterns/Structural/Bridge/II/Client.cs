using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Bridge.II
{
    public class Client
    {
        public static void Execute()
        {
            MessageAbstraction message1 = new MessageAbstraction(new SmsGate());

            message1.SendMessage(Console.ReadLine());

            MessageAbstraction message2 = new ShortMessageAbstraction(new EmailGate());

            message2.SendMessage(Console.ReadLine());
        }
    }
}
