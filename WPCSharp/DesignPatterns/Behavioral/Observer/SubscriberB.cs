using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class SubscriberB : Subscriber
    {
        public SubscriberB(IObservable<int> publisher) : base(publisher)
        {
        }

        public override void OnNext(int value)
        {
            if(value > 8 || value < 3)
                Console.WriteLine($"{GetType().Name}: reaguje na zmianę");
        }
    }
}
