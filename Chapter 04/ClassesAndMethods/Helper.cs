namespace ClassesAndMethods
{
    public static class Helper
    {
        public static string GetUniqueIdentifier()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
