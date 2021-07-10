using OrderProcessor.EventModels;
using System;

namespace OrderProcessor
{
    public class ActionRoyaltyDepartment : FinishProcessor<ActionEventArgs>
    {
        public override void GetCalled(object sender, ActionEventArgs t)
        {
            Console.WriteLine("create a duplicate packing slip for the royalty department.");
        }
    }
    
}