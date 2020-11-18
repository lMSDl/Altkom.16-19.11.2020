using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Strategy
{
    public class Client
    {
        public static void Execute()
        {
            var calc = new Calculator();

            while (true)
            {
                var line = Console.ReadLine();

                var split = line.Split(' ');
                if (split.Length < 3)
                    continue;

                calc.Strategy = GetCalcStrategy(split[1]);


                if (float.TryParse(split[0], out float val1) &&
                    float.TryParse(split[2], out float val2))
                {
                    var result = calc.Calculate(val1, val2);
                    Console.WriteLine(result);

                    result = calc.Calculate(val1, val2, GetFunc(split[1]));
                    Console.WriteLine(result);

                    result = GetFunc(split[1]).Invoke(val1, val2);
                    Console.WriteLine(result);
                }
            }
        }

        private static IStrategy GetCalcStrategy(string v)
        {
            switch (v)
            {
                case "*":
                    return new MultiplyStrategy();
                case "/":
                    return new DivideStrategy();
                case "+":
                    return new PlusStrategy();
                case "-":
                    return new MinusStrategy();
                default:
                    return null;
            }
        }

        private static Func<float, float, float?> GetFunc(string arg)
        {
            switch (arg)
            {
                case "*":
                    return (a, b) => a * b;
                case "/":
                    return (a, b) => a / b;
                case "+":
                    return (a, b) => a + b;
                case "-":
                    return (a, b) => a - b;
                default:
                    return null;
            }
        }
    }
}
