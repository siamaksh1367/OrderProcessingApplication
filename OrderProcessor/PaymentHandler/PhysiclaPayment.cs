using System;
using System.Collections.Generic;

namespace OrderProcessor
{
    public class PhysiclaPayment : GeneralPayment
    {
        public PhysiclaPayment(List<IObserver<PaymentDto>> observers) : base(observers)
        {
        }

        public override void ProcessPayment(PaymentDto paymentDto)
        {
            System.Console.WriteLine("Payment Process");
            Process(paymentDto);
        }
    }
}
