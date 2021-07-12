namespace OrderProcessor
{
    public class VideoPacking : GeneralPacking
    {
        public override void OnNext(PaymentDto value)
        {
            AddFirstAid();
        }
    }
}
