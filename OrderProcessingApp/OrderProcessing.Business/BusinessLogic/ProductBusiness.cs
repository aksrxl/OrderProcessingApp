using OrderProcessingApp.Model;
using System.Collections.Generic;
using OrderProcessingApp.Data.IRepository;

namespace OrderProcessing.Business.BusinessLogic
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepository productRepository;

        public ProductBusiness(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public List<ProductDetail> GetProductList()
        {
             return productRepository.GetProductList();
        }
    }
}
