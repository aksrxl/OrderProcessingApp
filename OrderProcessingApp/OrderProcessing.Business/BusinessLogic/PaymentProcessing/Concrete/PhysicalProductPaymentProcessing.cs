using OrderProcessing.Business.PaymentProcessing;
using OrderProcessingApp.Data.IRepository;

namespace OrderProcessing.Business.BusinessLogic.PaymentProcessing.Concrete
{
    public class PhysicalProductPaymentProcessing : IPaymentProcessing
    {
        private readonly IProductRepository productRepository;
        public PhysicalProductPaymentProcessing(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public string Process(int productId)
        {
            return productRepository.ProcessProductAndGeneratePackingSlip(productId);
        }
    }
}
