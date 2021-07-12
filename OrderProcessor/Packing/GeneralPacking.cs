using System;

namespace OrderProcessor
{
    public abstract class GeneralPacking : GeneralObserver<PaymentDto>
    {
        protected virtual void AddFirstAid()
        {
            Console.WriteLine("AddFirstAid");
        }

        protected virtual void DuplicateSlips()
        {
            Console.WriteLine("DuplicateSlips");
        }

        protected virtual void GenerateSlips()
        {
            Console.WriteLine("GenerateSlips");
        }
    }
}
