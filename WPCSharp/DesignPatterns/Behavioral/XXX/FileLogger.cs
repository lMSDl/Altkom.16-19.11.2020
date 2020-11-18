using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.XXX
{
    public class FileLogger : Logger<FileService>
    {

        protected override void OnSaveLog(string message)
        {
            Console.WriteLine("Appending Log message to file : " + message);
        }

        protected override void OnCloseService()
        {
            Console.WriteLine("Close File.");
        }

        protected override void OnConnectToService()
        {
            Console.WriteLine("Opening File.");
        }

        protected override void SaveLog(FileService service, string message)
        {
            service.Write(message);
        }

        protected override FileService ConnectToService()
        {
            return new FileService();
        }
    }
}
