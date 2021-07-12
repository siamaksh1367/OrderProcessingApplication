namespace OrderProcessor
{
    public abstract class GeneralNotify : GeneralObserver<PaymentDto>, INotify
    {
        public virtual void SendAMail()
        {
            System.Console.WriteLine("SendAMail");
        }
    }
}
