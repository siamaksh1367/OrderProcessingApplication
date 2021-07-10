using OrderProcessor.EventModels;
using System;

namespace OrderProcessor
{
    public class OrderProcessorSimple : StartingProcessor<PaymentEventArgs>
    {
        public OrderProcessorSimple(MidProcessor<PaymentEventArgs, ActionEventArgs> payment):base()
        {
            Process+= payment.GetCalled;
        }
        public  void run()
        {
            Console.WriteLine("Processing the order just started");
            var payment = new PaymentEventArgs();
            OnProcessed(payment);
        }
    }
}


