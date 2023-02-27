namespace DesignPatterns.Facade
{
    public interface IOrderItemRepository
    {
        OrderProcess Insert(OrderProcess order, object item);
    }
}
