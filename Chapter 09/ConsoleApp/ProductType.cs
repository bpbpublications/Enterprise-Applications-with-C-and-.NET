namespace ConsoleApp
{
    internal class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        static List<ProductType> GetProductTypes()
        {
            var productTypes = new List<ProductType>();
            productTypes.Add(new ProductType() { Id = 1, Name = "Book"});
            productTypes.Add(new ProductType() { Id = 2, Name = "Magazine" });
            productTypes.Add(new ProductType() { Id = 3, Name = "Laptop" });




            return productTypes;
        }
    }
}
