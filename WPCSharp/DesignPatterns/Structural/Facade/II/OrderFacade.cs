using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Facade.II
{
    public class OrderFacade
    {
        private IPaymentService paymentService;
        private ICartService cartService;
        private IProductService productService;

        public OrderFacade(IPaymentService paymentService, ICartService cartService, IProductService productService)
        {
            this.paymentService = paymentService;
            this.cartService = cartService;
            this.productService = productService;
        }


        public void Order(int[] productIds, int cartId)
        {
            foreach (var item in productIds)
            {
                cartService.AddProduct(item, productService.GetPrice(item));
            }
            paymentService.Pay(cartId, cartService.GetPrice(cartId));
        }
    }
}
