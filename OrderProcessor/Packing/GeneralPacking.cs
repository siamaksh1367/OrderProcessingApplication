using System;

namespace OrderProcessor
{
    public abstract class GeneralPacking : GeneralObserver<PaymentDto>, IPacking
    {
        public virtual void AddFirstAid()
        {
            Console.WriteLine("AddFirstAid");
        }

        public virtual void DuplicateSlips()
        {
            Console.WriteLine("DuplicateSlips");
        }

        public virtual void GenerateSlips()
        {
            Console.WriteLine("GenerateSlips");
        }
    }
}
