using System;

namespace OrderProcessor
{
    public class OrderProcessorSimple : OrderProcessor
    {
        public OrderProcessorSimple(PaymentProcessor paymentProcessor):base(paymentProcessor)
        {
            
        }
        public override void ProcessOrder(Order order)
        {
            Console.WriteLine("Processing the order just started");
            OnOrderProcessing(order);
        }
    }
}


