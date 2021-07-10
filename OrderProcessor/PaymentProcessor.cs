using System;

namespace OrderProcessor
{

    public abstract class PaymentProcessor
    {
        public event EventHandler<PaymentEventArgs> PaymentProcessed;
        public abstract void OnOrderProcessing(object sender, OrderEventArgs order);
        protected virtual void OnPaymentProcessed(Payment payment)
        {
            PaymentProcessed?.Invoke(this, new PaymentEventArgs(payment));
        }
    }
}