namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = Product.GetProducts();

            var productFilter = products.Where(x => x.Price < 20).ToList();

            foreach(var product in productFilter )
            {
                Console.WriteLine($"Product:{product.Title}. Price: {product.Price} ");
            }


            products = Product.GetProducts();

            var orderedList = products.OrderBy(x => x.Title).ToList();

            foreach (var product in orderedList)
            {
                Console.WriteLine($"Product:{product.Title}");
            }

            products = Product.GetProducts();

            var titleList = products.Select(x=> x.Title).Where(x=> x.Contains("Magazine")).ToList();

            foreach (var title in titleList)
            {
                Console.WriteLine($"Product:{title}");
            }

            var customers = Customer.GetCustomers();


            var firstCustomer = customers.FirstOrDefault();
            var lastCustomer = customers.LastOrDefault();

            Console.WriteLine($"First customer: {firstCustomer.Name}");
            Console.WriteLine($"Last customer: {lastCustomer.Name}");


            products = Product.GetProducts();

            productFilter = products
                .Where(x => (x.Active == true && x.StorageQuantity > 50) || x.Purchases.Count > 1).ToList();

            foreach (var product in productFilter) 
            {
                Console.WriteLine($"Product:{product.Title}. Price: {product.Price} ");

            }

            customers = Customer.GetCustomers();

            bool hasCustomer = customers.Any(x => x.Address.Contains("New York"));

            if (hasCustomer)
            {
                Console.WriteLine("It has a customer with the New York keyword in the address");
            }

            customers = Customer.GetCustomers();
            var customersNewYork = customers.Where(x => x.Address.Contains("New York")).ToList();

            var allCustomerExceptNewYork = customers.Except(customersNewYork);

            List<int> firstList = new List<int> { 1, 2, 3,4, 5 };
            List<int> secondList = new List<int>() { 1,2,3,4,5 };

            List<int> intersectList = firstList.Intersect(secondList).ToList();


        }
    }
}