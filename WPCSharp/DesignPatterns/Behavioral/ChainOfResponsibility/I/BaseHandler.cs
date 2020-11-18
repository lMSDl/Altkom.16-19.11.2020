using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public class BaseHandler
    {
        public BaseHandler(IHandler nextHandler)
        {
            NextHandler = nextHandler;
        }

        protected IHandler NextHandler { get; }

        public string Name { get; set; }

    }
}
