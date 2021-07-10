using OrderProcessor.EventModels;
using System;

namespace OrderProcessor
{
    public class ActionMialService: FinishProcessor<ActionEventArgs>
    {
        public override void GetCalled(object sender, ActionEventArgs t)
        {
            Console.WriteLine("e-mail the owner and inform them of the activation/upgrade.");
        }
    }
    
}