using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Memento
{
    public class Memento<T> : IMemento<T>
    {
        public T State { get; }

        public DateTime DateTime { get; }

        public Memento(T state)
        {
            State = state;
            DateTime = DateTime.Now;
        }
    }
}
