using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class SubscriberA : Subscriber
    {
        public SubscriberA(IObservable<int> publisher) : base(publisher)
        {
        }

        public override void OnNext(int value)
        {
            if(value > 5)
                Console.WriteLine($"{GetType().Name}: reaguje na zmianę");
        }
    }
}
