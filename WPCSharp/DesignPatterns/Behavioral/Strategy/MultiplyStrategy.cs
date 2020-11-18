using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Strategy
{
    public class MultiplyStrategy : IStrategy
    {
        public float Calc(float value1, float value2)
        {
            return value1 * value2;
        }
    }
}
