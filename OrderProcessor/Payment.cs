namespace OrderProcessor
{
    public class Payment
    {
        private readonly PaymentType _paymentType;


        public Payment(PaymentType paymentType)
        {
            this._paymentType = paymentType;
        }

        public PaymentType PaymentType{ get { return _paymentType} private set { } }

    }
}