using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.State
{
    public class HeatingUpState : State
    {
        public override void Init()
        {
            var task = Task.Delay(TimeSpan.FromSeconds(5));
            task.ContinueWith(x => Context.TransitionTo(new IdleState()));
        }

        public override void LargeCoffee()
        {
            Console.WriteLine("HeatingUpState: I am heating up!");
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("HeatingUpState: I am heating up!");
        }
    }
}
