﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Strategy
{
    public class Calculator
    {
        public IStrategy Strategy { get; set; }

        public float? Calculate(float value1, float value2)
        {
            return Strategy?.Calc(value1, value2);
        }

        public float? Calculate(float value1, float value2, Func<float, float, float?> func)
        {
            return func(value1, value2);
        }
    }
}
