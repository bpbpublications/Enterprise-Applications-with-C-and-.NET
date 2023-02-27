using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class OrderProcessFacade
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderItemRepository _orderItemRepository;

        

        public OrderProcess InsertOrder(OrderProcess order)
        {
            var newOrder = _orderRepository.Insert(order);

            foreach(var item in order.Items)
            {
                NewMethod(order, newOrder, item);
            }

            return newOrder;
        }

        private void NewMethod(OrderProcess order, object newOrder, OrderItem item)
        {
           
        }
    }

    public class OrderItem
    {

    }
}
