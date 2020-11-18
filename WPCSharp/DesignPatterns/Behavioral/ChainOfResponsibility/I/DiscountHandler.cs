using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public class DiscountHandler : BaseHandler, IHandler
    {
        public float MaxDiscount { get; }

        public float MinPrice { get; }

        public DiscountHandler(float maxDiscount, float minPrice, IHandler handler) : base(handler) 
        {
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }
        public DiscountHandler(float maxDiscount, float minPrice) : this(maxDiscount, minPrice, null)
        {
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }



        public bool Discount(float value, float price)
        {
            if(MaxDiscount > value && price >= MinPrice)
            {
                Console.WriteLine($"Rabat przyznazny przez {Name}");
                return true;
            }
            return NextHandler?.Discount(value, price) ?? false;
        }
    }
}
