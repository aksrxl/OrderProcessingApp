using OrderProcessing.Business.PaymentProcessing;
using OrderProcessingApp.Data.IRepository;

namespace OrderProcessing.Business.BusinessLogic.PaymentProcessing.Concrete
{
    public class UpgradeMembershipPaymentProcessing : IPaymentProcessing
    {
        private readonly IProductRepository productRepository;
        public UpgradeMembershipPaymentProcessing(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public string Process(int productId)
        {
            return productRepository.ProcessProductAndUpgradeMemberShip(productId);
        }
    }
}
