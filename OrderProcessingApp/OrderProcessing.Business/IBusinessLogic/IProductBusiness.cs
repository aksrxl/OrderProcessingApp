using OrderProcessingApp.Model;
using System.Collections.Generic;

namespace OrderProcessing.Business.BusinessLogic
{
    public interface IProductBusiness
    {
        List<ProductDetail> GetProductList();
    }
}
