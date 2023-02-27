using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Title  { get; set; }
        public decimal Price { get; set; }
        public ProductType ProductType { get; set; }
        public bool IsOnlineProduct { get; set; }

        public decimal ApplyDiscount(Customer customer)
        {
            if(customer.Birthday.Day == DateTime.Now.Day && 
                customer.Birthday.Month == DateTime.Now.Month)
            {
                return this.Price * 0.70m;
            }

            if(ProductType == ProductType.Book)
            {
                return this.Price * 0.80m;
            }

            return this.Price;
        }
    }

    public enum ProductType
    {
        Book = 1,
        Laptop = 2,
        Magazine = 3
    }
}
