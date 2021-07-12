namespace OrderProcessor
{
    public abstract class GeneralMembership : GeneralObserver<PaymentDto>
    {
        protected virtual void ActivateMembership()
        {
            System.Console.WriteLine("ActivateMembership");
        }

        protected virtual void UpgradeMembership()
        {
            System.Console.WriteLine("UpgradeMembership");
        }
    }
}
