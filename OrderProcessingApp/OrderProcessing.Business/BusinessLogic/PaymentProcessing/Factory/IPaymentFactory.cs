using OrderProcessing.Business.PaymentProcessing;
using OrderProcessingApp.Model;

namespace OrderProcessing.Business.BusinessLogic.PaymentProcessing.Factory
{
    public interface IPaymentFactory
    {
        IPaymentProcessing GetPaymentProcessingInstance(ProductType productType);
    }
}
