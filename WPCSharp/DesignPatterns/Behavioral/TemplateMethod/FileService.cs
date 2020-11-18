using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class FileService : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Closing File.");
        }

        public void Write(string @string)
        {
            Console.WriteLine("Appending Log message to file : " + @string);
        }
    }
}
