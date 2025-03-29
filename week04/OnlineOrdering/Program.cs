// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System\n");

        // First order
        Address address1 = new Address("123 Main St", "Seattle", "WA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("LP100","Laptop", 999.99, 1));
        order1.AddProduct(new Product("MS200","Mouse", 24.99, 2));
        order1.AddProduct(new Product("KB300","Keyboard", 59.99, 1));
        
        Console.WriteLine("ORDER 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotal():F2}\n");

        // Second order
        Address address2 = new Address("456 Maple Ave", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product( "HP400","Headphones", 129.99, 1));
        order2.AddProduct(new Product( "PC500","Phone Case", 19.99, 3));
        
        Console.WriteLine("ORDER 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotal():F2}");
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}