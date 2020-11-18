using System;

namespace WPCSharp.DesignPatterns.Behavioral.State
{
    public class IdleState : State
    {
        public override void Init()
        {
        }

        public override void LargeCoffee()
        {
            Console.WriteLine("IdleState: make large coffee");
            Context.TransitionTo(new WorkingState(8));
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("IdleState: make small coffee");
            Context.TransitionTo(new WorkingState(5));
        }
    }
}