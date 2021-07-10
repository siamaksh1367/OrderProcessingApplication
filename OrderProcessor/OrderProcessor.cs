using System;

namespace OrderProcessor
{
    public abstract class OrderProcessor 
    {

        public OrderProcessor(PaymentProcessor paymentProcessor)
        {
            OrderProcessing += paymentProcessor.OnOrderProcessing;
        }
        public event EventHandler<OrderEventArgs> OrderProcessing;
        public abstract void ProcessOrder(Order order);
        protected virtual void OnOrderProcessing(Order order) 
        {
            OrderProcessing?.Invoke(this, new OrderEventArgs(order));
        }
    }
}
