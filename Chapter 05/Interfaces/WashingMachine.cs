namespace Interfaces
{
    public class WashingMachine : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int HeightDimension { get; set; }
        public int WidthDimension { get; set; }
        public int Type { get; set; }
        public string InternetPlan { get; set; }

        public decimal CalculateDiscount()
        {
            return 0.3m;
        }
    }
}
