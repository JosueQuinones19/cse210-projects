using System;

class Program
{
    static void Main(string[] args)
    {
        // Customers
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer cust1 = new Customer("Josue", addr1);

        Address addr2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Ashley", addr2);

        // Products
        Product prod1 = new Product("Laptop", "A001", 999.99, 1);
        Product prod2 = new Product("Mouse", "A002", 25.50, 2);
        Product prod3 = new Product("Keyboard", "A003", 45.00, 1);
        Product prod4 = new Product("Monitor", "B001", 199.99, 1);
        Product prod5 = new Product("USB Cable", "B002", 10.00, 3);

        // Orders
        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);
        order1.AddProduct(prod3);

        Order order2 = new Order(cust2);
        order2.AddProduct(prod4);
        order2.AddProduct(prod5);

        // Display Orders
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
