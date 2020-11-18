﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseService : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Closing DB connection.");
        }

        public void Insert(string @string)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + @string);
        }
    }
}
