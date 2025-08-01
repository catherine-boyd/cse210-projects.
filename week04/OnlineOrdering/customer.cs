using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering
{
    internal class Customer
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
}