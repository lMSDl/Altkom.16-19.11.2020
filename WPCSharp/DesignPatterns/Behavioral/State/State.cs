namespace WPCSharp.DesignPatterns.Behavioral.State
{
    public abstract class State : IState<CoffeeMachine>
    {
        private CoffeeMachine context;

        public CoffeeMachine Context
        {
            protected get => context;
            set
            {
                context = value;
                Init();
            }
        }

        public abstract void Init();

        public abstract void LargeCoffee();

        public abstract void SmallCoffee();
    }
}
