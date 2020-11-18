using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Strategy
{
    public interface IStrategy
    {
        float Calc(float value1, float value2);
    }
}
