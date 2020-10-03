using OrderProcessing.Business.PaymentProcessing;
using OrderProcessingApp.Data.IRepository;

namespace OrderProcessing.Business.BusinessLogic.PaymentProcessing.Concrete
{
    public class VideoPaymentProcessing : IPaymentProcessing
    {
        private readonly IProductRepository productRepository;
        public VideoPaymentProcessing(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public string Process(int productId)
        {
           return productRepository.ProcessProductAndAddFreeAidVideo(productId);
        }
    }
}
