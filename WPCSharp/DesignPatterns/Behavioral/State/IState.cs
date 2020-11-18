using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.State
{
    public interface IState<T>
    {
        T Context { set; }
        void SmallCoffee();
        void LargeCoffee();
    }
}
