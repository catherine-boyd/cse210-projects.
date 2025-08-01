using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering
{
    internal class Order
    {

        private List<Product> _products = new List<Product>();
        private Customer _customer;
        private double _totalCost = 0;
        private static double _shippingCost = 0;

        public Order(List<Product> products, Customer customer, double totalCost)
        {
            _products = products;
            _customer = customer;
            _totalCost = totalCost;
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
            return _totalCost + _shippingCost;
        }

        public void ShippingLabel()
        {
            Console.WriteLine($"Customer name: {_customer.GetName()} Customer Address: {_customer.GetAddress()}");
        }
        public void PackingLabel()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine($"product name: {product.GetName()} product Id: {product.GetId()}");
            }
            ;
        }
    }
}