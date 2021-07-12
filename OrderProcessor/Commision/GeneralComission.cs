namespace OrderProcessor
{
    public abstract class GeneralComission : GeneralObserver<PaymentDto>
    {
        protected void GenerateComisiion()
        {
            System.Console.WriteLine("GenerateComisiion");
        }
    }
}
