using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class OnlineProductBuilder: ProductBuilder
    {
        private Product _product = new Product();

        public override void BuildName()
        {
            HttpClient httpClient = new HttpClient();
            this._product.Name = httpClient.GetAsync("/getProductName").Result.Content.ReadAsStringAsync().Result;
        }

        public override void BuildPhotos()
        {
            HttpClient httpClient = new HttpClient();
            this._product.Name = httpClient.GetAsync("/getProductPhotos").Result.Content.ReadAsStringAsync().Result;
        }

        public override void BuildPrice()
        {
            HttpClient httpClient = new HttpClient();
            this._product.Name = httpClient.GetAsync("/getProductPrice").Result.Content.ReadAsStringAsync().Result;
        }

        public Product GetResult()
        {
            return this._product;
        }
    }
}
