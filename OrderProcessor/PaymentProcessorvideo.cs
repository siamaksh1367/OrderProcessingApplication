using OrderProcessor.EventModels;
using System;

namespace OrderProcessor
{
    public class PaymentProcessorvideo : MidProcessor<PaymentEventArgs, ActionEventArgs>
    {
        public PaymentProcessorvideo(FinishProcessor<ActionEventArgs> action)
        {
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