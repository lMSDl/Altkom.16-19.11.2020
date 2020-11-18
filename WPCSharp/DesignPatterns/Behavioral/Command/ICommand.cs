using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Command
{
    public interface ICommand
    {
        bool Execute();
        void Undo();
    }
}
