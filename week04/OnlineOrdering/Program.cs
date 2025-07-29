using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product(10.0, "Milk", 3, 5));
        products.Add(new Product(24.3, "Milo", 5, 6));
        products.Add(new Product(11.4, "Tin fish", 6, 10));
        Address address = new Address("Alang", "Accra", "Greater Accra", "Ghana");
        Customer customer = new Customer("Steve", address);
        Order order = new Order (products, customer,50);
        order.ShippingLabel();
        order.PackingLabel();
        double totalCost = order.TotalCost();
        Console.WriteLine($"Total Cost: ${totalCost}");




    }
}
class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _totalCost = 0 ;
    private static double _shippingCost = 0;

    public Order(List<Product> products, Customer customer, double totalCost )
    {
        _products = products ;
        _customer = customer ;
        _totalCost = totalCost ;
    }
    public double TotalCost()
    {
        foreach (Product product in _products)
        {
            _totalCost += product.GetTotalCost();
        }
        if (_customer.LivesInUSA())
        {
            _shippingCost = 5.0;
        }
        else
        {
            _shippingCost = 35.0;
        }
        return _totalCost + _shippingCost ;
    }

    public void ShippingLabel()
    {
        Console.WriteLine($"Customer name: {_customer.GetName()} Customer Address: {_customer.GetAddress()}");
    }
    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"product name: {product.GetName() } product Id: {product.GetId()}");
        };
    }
}

class Product
{
    private double _price = 0;
    private string _name = "";
    private int _productId = 0;
    private int _quantity = 0;

    public Product(double price,string name,int productId,int quantity)
    {
        _price = price;
        _name = name;
        _productId = productId;
        _quantity = quantity;
    }
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetId()
    {
        return _productId; 
    }
}

class Customer
{
    private string _name = "";
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;

    }

    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
    public bool LivesInUSA()
    {
        return this._address.IsCountryUSA();
    }


}

class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";

    public Address(string streetAddress, string city,string state,string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    public  string GetAddress()
    {
        return _country + " " +_city + " " + _state + " " + _streetAddress;
    }
    public bool IsCountryUSA()
    {
        if(_country == "USA")
        {
            return true;
        }
        return false ;
    }
}