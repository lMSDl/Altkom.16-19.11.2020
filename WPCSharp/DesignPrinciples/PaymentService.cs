using System.Collections.Generic;
using System.Linq;

namespace WPCSharp.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> Customers { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool Charge(int customerId, float amount)
        {
            PaymentAccount customer = FindCustomerById(customerId);
            return customer?.Charge(amount) ?? false;
        }

        private PaymentAccount FindCustomerById(int customerId)
        {
            return Customers.SingleOrDefault(x => x.Id == customerId);
        }

        public void Fund(int customerId, float amount)
        {
            PaymentAccount customer = FindCustomerById(customerId);
            customer?.Fund(amount);
        }
    }
}
