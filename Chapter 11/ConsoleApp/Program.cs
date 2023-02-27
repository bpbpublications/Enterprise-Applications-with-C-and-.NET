namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Customer 1",
                BirthDay = DateTime.Now,
                Address = "Address of the customer 1"
            };

            var customer2 = customer1 with { Name = "Customer 2" };

            Console.WriteLine(customer2.Name);

            customer2.Name = customer1.Name;

            Console.WriteLine("Returns true:" + customer1.Equals(customer2));
            Console.WriteLine("Returns false: " + (customer1 == customer2));

        }

        static void SwitchExpression()
        {
            string messageCustomer = DateTime.Now.DayOfWeek switch
            {
                DayOfWeek.Monday => "The promotion is not available",
                DayOfWeek.Tuesday => "The promotion is available only for Laptops",
                DayOfWeek.Wednesday => "The promotion is available for all products",
                DayOfWeek.Thursday => "The promotion is available only for Books",
                DayOfWeek.Friday => "You are lucky. It is Friday and all the products have twenty percent discount"
                _ => "None of the products have discount now"
            };

            Console.WriteLine(messageCustomer);

        }

        static void NewUsingImplementation()
        {
            using StreamReader quotationFile = new StreamReader("quotation.txt");

            string quotation;

            while((quotation = quotationFile.ReadLine()) != null)
            {
                Console.WriteLine(quotation);
            }
        }

        static void OldUsingImplementation()
        {
            using (StreamReader quotationFile = new StreamReader("quotation.txt"))
            {
                string quotation;

                while ((quotation = quotationFile.ReadLine()) != null)
                {
                    Console.WriteLine(quotation);
                }
            }
        }

        private static async IAsyncEnumerable<decimal> GetPriceAsync()
        {
            foreach (var healhPlan in GetHealPlans())
            {
                decimal price = await new HealPlanService().GetPrice(healhPlan);
                yield return price;
            }
        }

        private static IEnumerable<object> GetHealPlans()
        {
            return null;
        }

        private static async Task AsyncStreamExample()
        {
            await foreach (var price in GetPriceAsync()) 
            {
                Console.WriteLine(price);
            }
        }

        private static void IndicesAndRangeExample()
        {
            var healthPlans = new string[]
            {
                "Plan1",
                "Plan2",
                "Plan3",
                "Plan4",
                "Plan5",
                "Plan6",
                "Plan7",
                "Plan8",
                "Plan9",
                "Plan10"
               
            };

            var firstPlan = healthPlans[0];
            var lastPlan = healthPlans[^1];

            Console.WriteLine("First Plan: " + firstPlan);
            Console.WriteLine("Last Plan: " + lastPlan);

            var firstFoursPlan = healthPlans[..4];

            var allPlans = healthPlans[..];

            var lastThreePlans = healthPlans[^3..];
        }
    }
}