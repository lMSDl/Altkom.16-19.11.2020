using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPCSharp.SOLID.D
{
    public interface IMessage
    {
        void Send();
    }

    public class SMS : IMessage
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            Console.WriteLine("Sending SMS...");
        }
    }
    public class MMS : IMessage
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void Send()
        {
            Console.WriteLine("Sending MMS...");
        }
    }
    public class Email : IMessage
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public void Send()
        {
            Console.WriteLine("Sending Email...");
        }
    }

    public class Messanger
    {
        public IEnumerable<IMessage> Messages { get; set; }

        public void Send()
        {
            Messages.ToList().ForEach(x => x.Send());
        }
    }
}
