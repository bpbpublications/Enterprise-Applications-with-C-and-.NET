namespace Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        int HeightDimension { get; set; }
        int WidthDimension { get; set; }
        int Type { get; set; }
        decimal CalculateDiscount()
        {
            return 0.3m;
        }

    }
}
