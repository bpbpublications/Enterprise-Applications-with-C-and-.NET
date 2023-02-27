namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IProduct> products = new List<IProduct>();

            IProduct product1 = new WashingMachine();
            product1.Name = "Washing Machine";

            IProduct product2 = new MobilePhone();
            product2.Name = "Mobile Phone";

            products.Add(product1);
            products.Add(product2);

            foreach(var product in products)
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadLine();
        }
    }
}