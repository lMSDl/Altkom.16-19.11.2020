﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Proxy
{
    public class Client
    {
        public static void Execute()
        {
            IDatabase database = new Database();
            database = new DatabaseProxy((Database)database);

            for (var i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadKey();

            for (var i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }
        }
    }
}
