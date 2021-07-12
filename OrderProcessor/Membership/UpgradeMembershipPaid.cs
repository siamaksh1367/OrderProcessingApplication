namespace OrderProcessor
{
    public class UpgradeMembershipPaid : GeneralMembership
    {
        public override void OnNext(PaymentDto value)
        {
            UpgradeMembership();
        }
    }
}
