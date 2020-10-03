using OrderProcessing.Business.PaymentProcessing;
using OrderProcessingApp.Data.IRepository;
using OrderProcessingApp.Model;
using System;

namespace OrderProcessing.Business.BusinessLogic.PaymentProcessing.Factory
{
    public class BusinessPaymentProcessing : IPaymentFactory
    {
        private readonly IProductRepository productRepository;

        public BusinessPaymentProcessing(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
       
        public IPaymentProcessing  GetPaymentProcessingInstance(ProductType productType)
        {
            var enumName = Enum.GetName(typeof(ProductType), productType);
            return (IPaymentProcessing)Activator.CreateInstance(Type.GetType($"OrderProcessing.Business.BusinessLogic.PaymentProcessing.Concrete.{enumName}PaymentProcessing"), productRepository);
        }
    }
}
