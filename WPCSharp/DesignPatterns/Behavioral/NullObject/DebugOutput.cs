using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.NullObject
{
    public class DebugOutput : Output
    {
        public override void Show(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
