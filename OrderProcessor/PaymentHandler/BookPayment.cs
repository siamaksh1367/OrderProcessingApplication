using System;
using System.Collections.Generic;

namespace OrderProcessor
{
    public class BookPayment: GeneralPayment
    {
        public BookPayment(List<IObserver<PaymentDto>> observers) : base(observers)
        {
        }

        public override void ProcessPayment(PaymentDto paymentDto)
        {
            System.Console.WriteLine("Payment Process");
            Process(paymentDto);
        }
    }
}
