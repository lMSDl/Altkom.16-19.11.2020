using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Facade.II
{
    public interface IProductService
    {
        float GetPrice(int cartId);
    }
}
