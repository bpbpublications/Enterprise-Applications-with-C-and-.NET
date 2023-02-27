using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Product: IProduct
    {
        public Product(string title)
        {
            this.Ttitle = title;
        }
        public int Id { get; set; }
        public string Ttitle { get; set; }
        public decimal Price { get; set; }
    }
}
