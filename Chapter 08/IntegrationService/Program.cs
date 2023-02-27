namespace IntegrationService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntegrationService integrationService = new IntegrationService();

            try
            {
                var info = integrationService.RequestInfo();
            }
            catch(IntegrationException ex) when (ex.CustomCode == 9001)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                integrationService.CloseConnection();
            }
        }
    }
}