using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_assignment
{
    interface IPayment
    {
        void ProcessPayment(double amount);
    }

    class CreditCard : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Credit Card payment of ${amount} processed.");
        }
    }

    class Bitcoin : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Bitcoin payment of ${amount} processed.");
        }
    }

    class Fifth_two
    {
        static void Main()
        {
            IPayment payment1 = new CreditCard();
            payment1.ProcessPayment(200);

            IPayment payment2 = new Bitcoin();
            payment2.ProcessPayment(300);
        }
    }
}
