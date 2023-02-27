namespace ConsoleApp
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public string ShippingAddress { get; set; }
        public List<Product> Products { get; set; }

        public bool IsAddressApplicable()
        {
            var hasPhysicalProducts = this.Products.Any(x => x.IsOnlineProduct == false);

            return hasPhysicalProducts;
        }
    }
}
