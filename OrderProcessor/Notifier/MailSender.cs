namespace OrderProcessor
{
    public class MailSender : GeneralNotify
    {
        public override void OnNext(PaymentDto value)
        {
            SendAMail();
        }
    }
}
