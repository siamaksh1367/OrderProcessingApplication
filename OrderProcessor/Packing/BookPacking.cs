namespace OrderProcessor
{
    public class BookPacking : GeneralPacking
    {
        public override void OnNext(PaymentDto value)
        {
            DuplicateSlips();
        }
    }
}
