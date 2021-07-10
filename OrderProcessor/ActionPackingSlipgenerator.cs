using OrderProcessor.EventModels;
using System;

namespace OrderProcessor
{
    public class ActionPackingSlipgenerator : FinishProcessor<ActionEventArgs>
    {
        public override void GetCalled(object sender, ActionEventArgs t)
        {
            Console.WriteLine("generate a packing slip for shipping");
        }
    }
    
}