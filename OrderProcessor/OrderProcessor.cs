using System;

namespace OrderProcessor
{
    public abstract class OrderProcessor 
    {
        public event EventHandler<OrderEventArgs> OrderProcessing;
        public abstract void ProcessOrder(Order order);
        protected virtual void OnOrderProcessing(Order order) 
        {
            OrderProcessing?.Invoke(this, new OrderEventArgs(order));
        }
    }
}
