using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public static List<Customer> GetCustomers() 
        { 
            var customers = new List<Customer>();

            customers.Add(new Customer() { Id = 1, Name = "Customer 1" });
            customers.Add(new Customer() { Id = 2, Name = "Customer 2" });


            return customers;
        }
    }
}
