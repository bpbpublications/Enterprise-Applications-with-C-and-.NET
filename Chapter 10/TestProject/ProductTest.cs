using ConsoleApp;

namespace TestProject
{
    public class ProductTest
    {
        [Fact]
        public void ShouldApplyTwentyPercentDiscountForBooks()
        {
            Product product = new Product()
            {
                Id = 1,
                IsOnlineProduct = false,
                ProductType = ProductType.Book,
                Price = 100.00m,
                Title = "Test Product",
            };

            Customer customer = new Customer();

            var result = product.ApplyDiscount(customer);
            Assert.Equal(80.00m, result);

        }

        [Fact]
        public void ShouldApplyThirtyPercentDiscountCustomerAnninversary()
        {
            Product product = new Product()
            {
                Id = 1,
                IsOnlineProduct = false,
                ProductType = ProductType.Book,
                Price = 100.00m,
                Title = "Test Product",
            };

            Customer customer = new Customer();
            customer.Birthday = DateTime.Now.AddYears(-30);

            var result = product.ApplyDiscount(customer);
            Assert.Equal(70.00m, result);

        }

        [Theory]
        [InlineData(100,100)]
        [InlineData(200, 200)]
        [InlineData(300, 300)]

        public void ShouldNotApplyAnyDiscount(decimal price, decimal expected)
        {
            Product product = new Product()
            {
                Id = 1,
                IsOnlineProduct = false,
                ProductType = ProductType.Laptop,
                Price = price,
                Title = "Test Product",
            };

            Customer customer = new Customer();

            var result = product.ApplyDiscount(customer);
            Assert.Equal(expected, result);

        }


    }
}
