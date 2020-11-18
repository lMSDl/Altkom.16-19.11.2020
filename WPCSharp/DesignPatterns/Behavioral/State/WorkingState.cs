using System;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.State
{
    public class WorkingState : State
    {
        private readonly int _time;
        private CancellationTokenSource _cancellationTokenSource;

        public WorkingState(int time)
        {
            _time = time;
        }

        public override void Init()
        {
            Console.WriteLine("WorkingState: Preparing coffee");
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Delay(TimeSpan.FromSeconds(_time), _cancellationTokenSource.Token)
                .ContinueWith(x =>
                {
                    Context.TransitionTo(new IdleState());
                    _cancellationTokenSource.Dispose();
                });
        }

        public override void LargeCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: process cancelled");
        }

        public override void SmallCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: process cancelled");
        }
    }
}