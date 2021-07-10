using OrderProcessor.EventModels;
using System;

namespace OrderProcessor
{
    public class PaymentProcessorPhysicalPruduct : MidProcessor<PaymentEventArgs,ActionEventArgs>
    {
        public PaymentProcessorPhysicalPruduct(FinishProcessor<ActionEventArgs> action)
        {
            Process += action.GetCalled;
        }
        
        public override void GetCalled(object sender, PaymentEventArgs t)
        {
            Console.WriteLine("Payment process finished for a Physical Pruduct ");
            var actionData= new ActionEventArgs();
            OnProcessed(actionData);
        }
    }
    
}