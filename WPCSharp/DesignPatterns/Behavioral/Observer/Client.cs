using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class Client
    {
        public static void Execute()
        {
            using (var subject = new Publisher())
            {
                var observerA = new SubscriberA(subject);
                var observerB = new SubscriberB(subject);

                subject.Work();
                subject.Work();

                subject.Work();

                Console.WriteLine("Ręczna zmiana stanu");
                subject.Index = 1;
            }
        }
    }
}
