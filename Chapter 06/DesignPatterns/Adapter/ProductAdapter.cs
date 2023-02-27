using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DesignPatterns.Adapter
{
    public interface IProduct
    {
        string GetAllProducts();
    }
    public class ProductAdapter: ProductManager, IProduct
    {
        public override string GetAllProducts()
        {
            string returnXml = base.GetAllProducts();
            XmlDocument document = new XmlDocument();
            document.LoadXml(returnXml);

            return JsonConvert.SerializeObject(document, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
