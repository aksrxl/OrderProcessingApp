using OrderProcessing.Business.PaymentProcessing;
using OrderProcessingApp.Data.IRepository;

namespace OrderProcessing.Business.BusinessLogic.PaymentProcessing.Concrete
{
    public class BookPaymentProcessing : IPaymentProcessing
    {
        private readonly IProductRepository productRepository;
        public BookPaymentProcessing(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public string Process(int productId)
        {
            return productRepository.ProcessProductAndCreateDuplicatePackingSlip(productId);
        }
    }
}
