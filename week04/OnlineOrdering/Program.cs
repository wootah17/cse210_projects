using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Main Street", "New York", "NY", "USA");
        Address address2 = new Address("45 King Street", "Toronto", "Ontario", "Canada");
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Mary Jones", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P003", 50, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P004", 500, 1));
        order2.AddProduct(new Product("Headphones", "P005", 75, 2));
        order2.AddProduct(new Product("Charger", "P006", 20, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.GetTotalCost():0.00}");

        Console.WriteLine("\n-------------------------\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.GetTotalCost():0.00}");
    }
}