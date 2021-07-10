using OrderProcessor.EventModels;
using System;

namespace OrderProcessor
{
    public class ActionUpgrade : FinishProcessor<ActionEventArgs>
    {
        public override void GetCalled(object sender, ActionEventArgs t)
        {
            Console.WriteLine("apply the upgrade.");
        }
    }

}