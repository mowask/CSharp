using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_m03_1
{
    internal class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        

        public void changeTelephone(string newTel) { Telephone = newTel; }
        public void Print()
        {
            Console.WriteLine($"Title: {Name}  \nAddress: {Address} \nTheme: {Description} \nTel: {Telephone} \nEmail: {Email}");
        }
    }
}
