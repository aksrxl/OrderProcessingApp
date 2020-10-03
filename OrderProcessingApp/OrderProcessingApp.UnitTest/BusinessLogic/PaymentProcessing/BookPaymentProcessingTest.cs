using FakeItEasy;
using OrderProcessing.Business.BusinessLogic.PaymentProcessing.Concrete;
using OrderProcessing.Business.BusinessLogic.PaymentProcessing.Factory;
using OrderProcessingApp.Data.IRepository;
using OrderProcessingApp.Model;
using Xunit;

namespace OrderProcessingApp.UnitTest.BusinessLogic.PaymentProcessing
{
    [Collection("BookPaymentProcessingTest")]
    public class BookPaymentProcessingTest
    {
        [Fact]
        public void Calling_Process_For_Book_Payment_Processing_Calls_Product_Repository_And_Returns_Response()
        {

            // Arrange
            var productRepository = A.Fake<IProductRepository>();
            var bookPaymentProcessing = new BookPaymentProcessing(productRepository);
            var message = "Duplicate packing slip for the royalty department generated and comission has been added for Agent.";

            A.CallTo(() => productRepository.ProcessProductAndCreateDuplicatePackingSlip(1)).Returns(message);

            // Act
            var result = bookPaymentProcessing.Process(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(message, result);
            A.CallTo(() => productRepository.ProcessProductAndCreateDuplicatePackingSlip(1)).MustHaveHappened();
        }
    }
}
