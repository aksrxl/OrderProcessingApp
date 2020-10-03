namespace OrderProcessing.Business.PaymentProcessing
{
    public interface IPaymentProcessing
    {
        string Process(int productId);
    }
}
