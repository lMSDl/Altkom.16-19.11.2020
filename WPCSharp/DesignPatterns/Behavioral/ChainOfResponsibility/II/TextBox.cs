using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class TextBox : Container
    {
        public string InputText { get; set; }

        protected override void Click(bool handled)
        {
            if(handled)
            {
                base.Click(false);
            }
            else
            {
                Console.WriteLine("TextBox ma focus");
                base.Click(true);
            }
        } 
    }
}
