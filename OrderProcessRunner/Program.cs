using OrderProcessor;
using System;

namespace OrderProcessRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProc = new OrderProcessorSimple(new PaymentProcessorPhysicalPruduct());
            orderProc.ProcessOrder(new Order(){ OrderNumber=1});
        }
    }
}
