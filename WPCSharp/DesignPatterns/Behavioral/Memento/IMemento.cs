using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Memento
{
    public interface IMemento<T>
    {
        T State { get; }
        DateTime DateTime { get; }
    }
}
