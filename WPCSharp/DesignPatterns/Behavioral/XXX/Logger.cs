using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.XXX
{
    public abstract class Logger<T> where T : IDisposable 
    {
        public void Log(string message)
        {
            string messageToLog = Serialize(message);
            OnSerialize();
            using (var service = ConnectToService())
            {
                OnConnectToService();
                SaveLog(service, messageToLog);
                OnSaveLog(messageToLog);
            }
            OnCloseService();
        }

        protected virtual void OnSerialize() { }
        protected abstract void OnSaveLog(string message);
        protected abstract void OnCloseService();

        protected abstract void OnConnectToService();
        protected abstract void SaveLog(T service, string message);
        protected abstract T ConnectToService();
        
        private string Serialize(string message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
    }
}
