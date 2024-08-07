using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L7
{
    internal class Laptop
    {
        public string Vendor { get; set; }
        public double Price { get; set; }
               

        public override string ToString()
        {
            return $"{Vendor} {Price}";
        }
    }
}
