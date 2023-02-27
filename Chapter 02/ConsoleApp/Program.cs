using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClassLibrary.Message.GetCustomMessage());
            Console.ReadLine();
        }
    }
}
