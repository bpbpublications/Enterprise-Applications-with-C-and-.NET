using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class ProductTracker: IObservable<Product>
    {
        private List<IObserver<Product>> observers;

        public ProductTracker()
        {
            observers = new List<IObserver<Product>>();
        }

        public IDisposable Subscribe(IObserver<Product> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new Unsubscriber(observers, observer);
        }

        public void TrackProduct(Product product)
        {

        }

        public void EndTransmission()
        {

        }

        private class Unsubscriber: IDisposable
        {
            public Unsubscriber(List<IObserver<Product>> observers, IObserver<Product> observer)
            {

            }

            public void Dispose()
            {
                
            }
        }
    }
}
