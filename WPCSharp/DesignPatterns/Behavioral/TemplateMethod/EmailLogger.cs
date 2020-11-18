using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class EmailLogger : Logger<IDisposable>
    {


        protected override void OnSaveLog(string message)
        {
            Console.WriteLine("Sending Email with Log Message : " + message);
        }

        protected override void OnCloseService()
        {
        }

        protected override void OnConnectToService()
        {
        }

        protected override void SaveLog(IDisposable service, string message)
        {
            Console.WriteLine("Sending Email with Log Message : " + message);
        }

        protected override IDisposable ConnectToService()
        {
            return null;
        }
    }
}
