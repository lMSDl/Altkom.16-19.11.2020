using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Facade.II
{
    public interface ICartService
    {
        float GetPrice(int cartId);
        float AddProduct(int productId, float price);
    }
}
