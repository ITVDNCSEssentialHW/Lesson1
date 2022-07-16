using System;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address();

            address1.Index = "123456";
            address1.Country = "Rus";
            address1.City = "Moscow";
            address1.Street = "Kastan";

            Console.WriteLine($"Index: {address1.Index}");
            Console.WriteLine($"Country: {address1.Country}");
            Console.WriteLine($"City: {address1.City}");
            Console.WriteLine($"Street: {address1.Street}");

            Console.ReadLine();
        }
    }
}
