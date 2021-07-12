namespace OrderProcessor
{
    public class MembershipPaid : GeneralMembership
    {
        public override void OnNext(PaymentDto value)
        {
            ActivateMembership();
        }
    }
}
