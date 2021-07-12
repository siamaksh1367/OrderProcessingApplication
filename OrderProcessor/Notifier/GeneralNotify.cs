namespace OrderProcessor
{
    public abstract class GeneralNotify : GeneralObserver<PaymentDto>
    {
        protected virtual void SendAMail()
        {
            System.Console.WriteLine("SendAMail");
        }
    }
}
