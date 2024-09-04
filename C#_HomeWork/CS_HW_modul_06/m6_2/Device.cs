using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_m06
{
    internal class Device
    {
        string _name { get; set; }
        string _description { get; set; }

        public Device() { }
        public Device(string name) 
        { 
            _name = name;
        }
        public Device (string name, string description)
        {
            _name = name;
            _description = description;
        }

        public virtual void Sound() {}
        public virtual void Show() 
        {
            Console.WriteLine("Name: " + _name);
        }
        public virtual void Description() 
        {
            Console.WriteLine($"Description: {_description}");
        }
        
    }
}
