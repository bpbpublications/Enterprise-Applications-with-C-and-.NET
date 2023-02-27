using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatterns.Adapter
{
    public class ProductManager
    {
        public List<Product> Products { get; set; }

        public ProductManager()
        {
            Products = new List<Product>();
            Products.Add(new Product() { Id = 1, Name = "Product A" });
            Products.Add(new Product() { Id = 2, Name = "Product B" });
            Products.Add(new Product() { Id = 3, Name = "Product C" });

        }

        public virtual string GetAllProducts()
        {
            var parser = new XmlSerializer(Products.GetType());

            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, null))
            {
                parser.Serialize(writer, Products, null);
                return stream.ToString();
            }
        }
    }
}
