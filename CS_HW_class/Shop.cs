using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_class
{
    internal class Shop
    {
        string _name;
        string _address;
        string _description;
        string _telephone;
        string _email;

        public Shop(string _name, string _addres, string _descriprion) {
            this._name = _name;
            this._address = _addres;
            this._description = _descriprion;
        }
        public string GetTelephone(string _telephone)
        {
            return this._telephone = _telephone;
        }
        public string GetEmail(string _email)
        {
            return this._email = _email;
        }
        public void changeTelephone(string newTelephone)
        {
            _telephone = newTelephone;
        }
        public void Print()
        {
            Console.WriteLine($"The store {_name} sells {_description} at the address: {_address}" +
                $"\ntel: {_telephone}, email: {_email}");
        }
    }
}
