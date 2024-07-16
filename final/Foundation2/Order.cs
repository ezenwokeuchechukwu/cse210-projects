using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    public Customer Customer { get; private set; }

    public Order(Customer customer)
    {
        Customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }

        double shippingCost = Customer.IsInUSA() ? 5 : 35;
        return total + shippingCost;
    }

    public string PackingLabel()
    {
        StringBuilder label = new StringBuilder("Packing Label:\n");
        foreach (var product in products)
        {
            label.AppendLine($"{product.Name} ({product.ProductId})");
        }
        return label.ToString();
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{Customer.Name}\n{Customer.Address}";
    }
}
