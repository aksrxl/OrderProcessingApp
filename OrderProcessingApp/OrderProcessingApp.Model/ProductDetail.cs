namespace OrderProcessingApp.Model
{
    public class ProductDetail
    {
        public int ProductId { get; set; }
        public ProductType ProductType { get; set; }
        public string ProductName { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        UnProcessed,
        Processed
    }
}
