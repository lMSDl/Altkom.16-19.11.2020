using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.State
{
    public class CoffeeMachine
    {
        private IState<CoffeeMachine> _state;

        public CoffeeMachine()
        {
            TransitionTo(new HeatingUpState());
        }

        public void LargeCoffee()
        {
            _state.LargeCoffee();
        }

        public void SmallCoffee()
        {
            _state.SmallCoffee();
        }

        public void TransitionTo(IState<CoffeeMachine> state)
        {
            Console.WriteLine($"Maszyna zmienia stan na {state.GetType().Name}");
            _state = state;
            state.Context = this;
        }
    }
}
