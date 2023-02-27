using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Purchase
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime PaymentDate { get; set; }
        public Product Product { get; set; }
    }
}
