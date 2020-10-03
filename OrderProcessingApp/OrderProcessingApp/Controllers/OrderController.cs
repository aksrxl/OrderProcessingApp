using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Business.BusinessLogic;
using OrderProcessing.Business.BusinessLogic.PaymentProcessing.Factory;
using OrderProcessingApp.Model;

namespace OrderProcessingApp.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IProductBusiness productBusiness;
        private readonly IPaymentFactory paymentFactory;
        public OrdersController(IProductBusiness productBusiness, IPaymentFactory paymentFactory)
        {
            this.productBusiness = productBusiness;
            this.paymentFactory = paymentFactory;
        }
        // GET: OrdersController
        public ActionResult Orders()
        {
            return View("Orders", productBusiness.GetProductList());
        }


        //Processes the payment
        public ActionResult Process(int productId, ProductType productType)
        {
            var paymentProcessor = paymentFactory.GetPaymentProcessingInstance(productType);
            var message = paymentProcessor.Process(productId);
            ViewBag.Message = message;
            return View("Confirmation");
        }
    }
}
