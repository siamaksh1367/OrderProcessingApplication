using OrderProcessor;
using System;

namespace OrderProcessRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new OrderProcessorSimple(new PaymentProcessorBook(new ActionRoyaltyDepartment()));
            order.run();
        }
    }
}
