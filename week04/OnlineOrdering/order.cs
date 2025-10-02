using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var p in products)
        {
            total += p.GetTotalPrice();
        }
        total += customer.IsInUSA() ? 5 : 35; // Shipping
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var p in products)
        {
            sb.AppendLine(p.GetPackingLabel());
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddressString()}";
    }
}
