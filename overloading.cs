using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_assignment
{
    class Overloading
    {
        public void MakePayment(string cardNumber, string cvv)
        {
            Console.WriteLine($"Processing credit card payment with Card Number: {cardNumber}");
        }

        public void MakePayment(string email)
        {
            Console.WriteLine($"Processing PayPal payment for Email: {email}");
        }

        public void MakePayment(int accountNumber, int bankCode)
        {
            Console.WriteLine($"Processing bank transfer for Account Number: {accountNumber}");
        }
    }

    //class Third
    //{
    //    static void Main()
    //    {
    //        Overloading payment = new Overloading();

    //        payment.MakePayment("1234567812345678", "123");   // Credit Card Payment
    //        payment.MakePayment("user@example.com");          // PayPal Payment
    //        payment.MakePayment(987654321, 1001);             // Bank Transfer Payment
    //    }
    //}
}
