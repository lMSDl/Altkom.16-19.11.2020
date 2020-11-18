using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.XXX
{
    public class DatabaseLogger : Logger<DatabaseService>
    {

        protected override void OnSaveLog(string message)
        {
        }

        protected override void OnCloseService()
        {
            Console.WriteLine("Closed DB connection.");
        }

        protected override void OnConnectToService()
        {
            Console.WriteLine("Connection to Database.");
        }

        protected override void SaveLog(DatabaseService service, string message)
        {
            service.Insert(message);
        }

        protected override DatabaseService ConnectToService()
        {
            return new DatabaseService();
        }
    }
}
