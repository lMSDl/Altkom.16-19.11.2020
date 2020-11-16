using System;

namespace WPCSharp.DesignPatterns.Creational.Singleton
{
    public class Client
    {
        public static void Execute()
        {
            string service1 = Context.GetInstance().GetSettings("1");
            Console.WriteLine($"Service: {service1}");

            string service2 = Context.GetInstance().GetSettings("2");
            Console.WriteLine($"Service: {service2}");

            Context.GetInstance().SetSettings("2", "X");
            service2 = Context.GetInstance().GetSettings("2");
            Console.WriteLine($"Service: {service2}");
        }
    }
}
