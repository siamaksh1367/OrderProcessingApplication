using OrderProcessor.EventModels;
using System;

namespace OrderProcessor
{
    public class ActionMembershipActivator : FinishProcessor<ActionEventArgs>
    {
        public override void GetCalled(object sender, ActionEventArgs t)
        {
            Console.WriteLine("activate that membership.");
        }
    }
    
}