namespace OrderProcessor
{
    public class PhysicalProductPacking : GeneralPacking
    {
        public override void OnNext(PaymentDto value)
        {
            GenerateSlips();
        }
    }
}
