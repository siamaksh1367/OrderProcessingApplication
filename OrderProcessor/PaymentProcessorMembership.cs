using OrderProcessor.EventModels;
using System;

namespace OrderProcessor
{
    public class PaymentProcessorMembership : MidProcessor<PaymentEventArgs, ActionEventArgs>
    {
        public PaymentProcessorMembership(FinishProcessor<ActionEventArgs> action)
        {
            Process += action.GetCalled;
        }

        public override void GetCalled(object sender, PaymentEventArgs t)
        {
            Console.WriteLine("Payment process finished for a Membership");
            var actionData = new ActionEventArgs();
            OnProcessed(actionData);
        }
    }
}