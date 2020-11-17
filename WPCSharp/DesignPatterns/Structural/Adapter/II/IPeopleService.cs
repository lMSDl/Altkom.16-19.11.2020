using System;
using System.Collections.Generic;
using System.Linq;

namespace WPCSharp.DesignPatterns.Structural.Adapter.II
{
    public interface IPeopleService
    {
        IEnumerable<IPerson> Get();
    }
}
