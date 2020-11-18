using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Command
{
    public abstract class Command : ICommand
    {
        protected Garden _garden;
        protected string _plant;

        protected Command(Garden garden, string plant)
        {
            _garden = garden;
            _plant = plant;
        }

        public abstract bool Execute();
        public abstract void Undo();
    }
}
