using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Proxy
{
    public interface IDatabase
    {
        Task<int?> RequestAsync(int parameter);
    }
}
