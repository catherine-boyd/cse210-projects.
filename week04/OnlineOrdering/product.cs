using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering
{
    internal class Product
    {

        private double _price = 0;
        private string _name = "";
        private int _productId = 0;
        private int _quantity = 0;

        public Product(double price, string name, int productId, int quantity)
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
}