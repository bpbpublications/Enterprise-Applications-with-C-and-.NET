using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class ProductNotifier: IObserver<Product>
    {
        private IDisposable unsubscriber;
        private string instName;

        public ProductNotifier(string productName)
        {
            this.instName = productName;
        }

        public string Name { get; set; }

        public virtual void Subscribe(IObservable<Product> provider)
        {
            if(provider != null)
            {
                unsubscriber = provider.Subscribe(this);
            }
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("The price transmission was completed to {0}", this.Name);
            this.Unsubscribe();
        }

        public virtual void OnError(Exception e)
        {
            Console.WriteLine("{0}: The price cannot be determined", this.Name);

        }

        public void OnNext(Product product)
        {
            Console.WriteLine("{2}: The current price is {0}, {1}", product.Price);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
