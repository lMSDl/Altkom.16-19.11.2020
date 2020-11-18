using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Command
{
    public class CommandInvoker
    {
        private ICommand _command;
        private static readonly Stack<ICommand> _commands = new Stack<ICommand>();

        public CommandInvoker(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            if(_command.Execute())
                _commands.Push(_command);
        }

        public static void Undo()
        {
            _commands.Pop()?.Undo();
        }
    }
}
