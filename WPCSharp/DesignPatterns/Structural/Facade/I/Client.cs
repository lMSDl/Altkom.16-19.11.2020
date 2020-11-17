using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WPCSharp.DesignPatterns.Structural.Facade.I
{
    public class Client
    {
        public static void Execute()
        {
            var item = new Person { Name = "Ewa Ewowska", Age = 32 };

            var json = JsonConvertFacade.Serialize(item);
            Console.WriteLine(json);
        }
    }
}
