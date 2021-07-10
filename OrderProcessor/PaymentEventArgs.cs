using System;

namespace OrderProcessor
{
    public class PaymentEventArgs: EventArgs
    {
        public PaymentEventArgs(Payment payment)
        {

        }
    }
}