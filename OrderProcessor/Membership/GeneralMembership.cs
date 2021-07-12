namespace OrderProcessor
{
    public abstract class GeneralMembership : GeneralObserver<PaymentDto>, IMembership
    {
        public virtual void ActivateMembership()
        {
            System.Console.WriteLine("ActivateMembership");
        }

        public virtual void UpgradeMembership()
        {
            System.Console.WriteLine("UpgradeMembership");
        }
    }
}
