namespace Inheritance
{
    public class Product
    {
        private decimal _price;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; private set; }
        public int Type { get; set; }

        public decimal CalculateDiscount()
        {
            return 0.5m;
        }

        public virtual void SetPrice()
        {
            this.Price = Convert.ToDecimal(100 * 0.9);
        }
    }
}
