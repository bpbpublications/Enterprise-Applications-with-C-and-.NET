namespace TryCatchBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int firstNumber = 100;
                int secondNumber = 0;

                var operation = firstNumber / secondNumber;
            }
            catch(DivideByZeroException ex)
            {

            }
            catch(Exception ex)
            {

            }
        }
    }
}