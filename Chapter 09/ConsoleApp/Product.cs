using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ProductType ProductType { get; set; }
        public decimal Price { get; set; }
        public int StorageQuantity { get; set; }
        public bool Active { get; set; }
        public List<Purchase> Purchases { get; set; }

        public static List<Product> GetProducts()
        {
            var products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Title = "BDP Publications - .NET",
                Active = true,
                ProductType = new ProductType() { Id = 1 },
                Price = 30.00m,
                StorageQuantity = 250
            });

            products.Add(new Product()
            {
                Id = 2,
                Title = "BDP Publications - Python",
                Active = true,
                ProductType = new ProductType() { Id = 1 },
                Price = 35.00m,
                StorageQuantity = 100,
                Purchases = GetPurchases(2, 1)
            });

            products.Add(new Product()
            {
                Id = 3,
                Title = ".NET Magazine",
                Active = false,
                ProductType = new ProductType() { Id = 2 },
                Price = 10.00m,
                StorageQuantity = 65
            });


            return products;
        }

        public static List<Purchase> GetPurchases(int productId, int customerId)
        {
            List<Purchase> purchases = new List<Purchase>();

            for(int i = 1; i > 5; i++)
            {
                purchases.Add(new Purchase()
                {
                    Id = i,
                    PaymentDate = DateTime.Now.AddDays(-i),
                    Customer = new Customer() { Id = customerId },
                    Product = new Product() { Id = productId }
                });
            }

            return purchases;
        }
    }
}
