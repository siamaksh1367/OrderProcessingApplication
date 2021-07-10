using OrderProcessor.EventModels;
using System;

namespace OrderProcessor
{
    public class PaymentProcessorBook : MidProcessor<PaymentEventArgs, ActionEventArgs>
    {
        public PaymentProcessorBook(FinishProcessor<ActionEventArgs> action)
        {
            Process += action.GetCalled;
            Process += action.GetCalled;

        }

        public override void GetCalled(object sender, PaymentEventArgs t)
        {
            Console.WriteLine("Payment process finished for a book");
            var actionData = new ActionEventArgs();
            OnProcessed(actionData);
        }
    }
}