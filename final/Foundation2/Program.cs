using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address addressUSA = new Address("123 Main St", "Anytown", "CA", "USA");
        Address addressCanada = new Address("456 Maple Ave", "Mapletown", "BC", "Canada");

        Customer customer1 = new Customer("Alice", addressUSA);
        Customer customer2 = new Customer("Bob", addressCanada);

        Product product1 = new Product("Phone", "P1", 399, 2);
        Product product2 = new Product("Laptop", "P2", 899, 1);
        Product product3 = new Product("Headphones", "P3", 149, 3);

        Order order1 = new Order(new List<Product> { product1, product2 }, customer1, 5);
        Order order2 = new Order(new List<Product> { product2, product3 }, customer2, 35);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GeneratePackingLabel());

        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GenerateShippingLabel());

        Console.WriteLine("\nOrder 1 Total Price:");
        Console.WriteLine("$" + order1.ComputeBilling());

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GeneratePackingLabel());

        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GenerateShippingLabel());

        Console.WriteLine("\nOrder 2 Total Price:");
        Console.WriteLine("$" + order2.ComputeBilling());

        Console.ReadKey(); 
    }
}
