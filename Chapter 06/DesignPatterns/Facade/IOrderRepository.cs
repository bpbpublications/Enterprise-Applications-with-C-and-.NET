namespace DesignPatterns.Facade
{
    public interface IOrderRepository
    {
        OrderProcess Insert(OrderProcess order);
    }
}
