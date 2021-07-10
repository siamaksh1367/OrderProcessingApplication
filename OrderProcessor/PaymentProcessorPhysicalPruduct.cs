using System;

namespace OrderProcessor
{
    public class PaymentProcessorPhysicalPruduct : PaymentProcessor
    {
        public override void OnOrderProcessing(object sender, OrderEventArgs order)
        {
            Console.WriteLine("Payment process finished for a Physical Pruduct ");
            var payment = new Payment();
            OnPaymentProcessed(payment);
        }
    }
}