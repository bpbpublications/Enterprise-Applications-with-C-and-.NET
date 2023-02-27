namespace MultipleInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WashingMachine machine = new WashingMachine() { Name = "Washing Machine", Price = 150 };

            EletronicBook eletronicBook = new EletronicBook()
            {
                Name = "Eletronic Book",
                Price = 25,
                DownloadSize = 2000
            };

            ProductData productData = new ProductData();

            productData.Create(machine);
            productData.Create(eletronicBook);
        }
    }
}