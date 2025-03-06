using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_assignment
{
    abstract class Payment
    {
        public abstract void ProcessPayment(double amount);

        public void GenerateReceipt()
        {
            Console.WriteLine("Receipt Generated.");
        }
    }

    class CreditCardPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Credit Card payment of ${amount}");
        }
    }

    class PayPalPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}");
        }
    }

    class Fifth_one
    {
        static void Main()
        {
            Payment payment1 = new CreditCardPayment();
            payment1.ProcessPayment(100);
            payment1.GenerateReceipt();

            Payment payment2 = new PayPalPayment();
            payment2.ProcessPayment(50);
            payment2.GenerateReceipt();
        }
    }
}
