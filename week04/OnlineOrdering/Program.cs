using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new List<Product>();
        products1.Add(new Product(10.0, "Milk", 3, 5));
        products1.Add(new Product(24.3, "Milo", 5, 6));
        products1.Add(new Product(11.4, "Tin fish", 6, 10));
        Address address1 = new Address("Alang", "Accra", "Greater Accra", "Ghana");
        Customer customer1 = new Customer("Steve", address1);
        Order order1 = new Order (products1, customer1,50);
        order1.ShippingLabel();
        order1.PackingLabel();
        double totalCost1 = order1.TotalCost();
        Console.WriteLine($"Total Cost1: ${totalCost1}");

        List<Product> products2 = new List<Product>();
        products2.Add(new Product(11.0, "Fish", 4, 6));
        products2.Add(new Product(25.3, "Rice", 6, 7));
        products2.Add(new Product(12.4, "Tomatoes", 7, 11));
        Address address2 = new Address("Kpone", "Tema", "Greater Accra", "Ghana");
        Customer customer2 = new Customer("Katherine", address2);
        Order order2 = new Order(products2, customer2, 50);
        order2.ShippingLabel();
        order2.PackingLabel();
        double totalCost2 = order2.TotalCost();
        Console.WriteLine($"Total Cost2: ${totalCost2}");
    }
}