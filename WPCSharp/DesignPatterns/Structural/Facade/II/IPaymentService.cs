using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Facade.II
{
    public interface IPaymentService
    {
        void Pay(int cartId, float amount);
    }
}
