namespace OrderProcessor
{
    public abstract class GeneralComission : GeneralObserver<PaymentDto>, IComission
    {
        public void GenerateComisiion()
        {
            System.Console.WriteLine("GenerateComisiion");
        }
    }
}
