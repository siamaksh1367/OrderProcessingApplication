using OrderProcessor.EventModels;
using System;

namespace OrderProcessor
{
    public class ActionCommision : FinishProcessor<ActionEventArgs>
    {
        public override void GetCalled(object sender, ActionEventArgs t)
        {
            Console.WriteLine("generate a commission payment to the agent.");
        }
    }

}