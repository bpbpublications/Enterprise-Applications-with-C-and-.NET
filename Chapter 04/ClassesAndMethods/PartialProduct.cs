namespace ClassesAndMethods
{
    public partial class Product
    {
        public Product()
        {

        }

        public Product(string title)
        {
            this.Title = title;
        }


        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
