namespace OrderProcessor
{
    public class AgentComission : GeneralComission
    {
        public override void OnNext(PaymentDto value)
        {
            GenerateComisiion();
        }
    }
}
