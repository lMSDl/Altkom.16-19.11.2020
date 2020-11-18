using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public interface IHandler
    {
        float MaxDiscount { get; }
        float MinPrice { get; }
        bool Discount(float value, float price);
    }
}
