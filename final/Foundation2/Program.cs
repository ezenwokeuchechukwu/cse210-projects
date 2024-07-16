using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create instances of Address and Customer
        var address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        var address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        var customer1 = new Customer("John Eric", address1);
        var customer2 = new Customer("Mary Smith", address2);

        // Create instances of Product
        var product1 = new Product("Laptop", "001", 1200, 1);
        var product2 = new Product("Mouse", "002", 25, 2);
        var product3 = new Product("Keyboard", "003", 50, 1);
        var product4 = new Product("Monitor", "004", 300, 2);

        // Create instances of Order
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Store orders in a list
        var orders = new List<Order> { order1, order2 };

        // Display order information
        foreach (var order in orders)
        {
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine($"Total Cost: ${order.TotalCost()}\n");
        }
    }
}
