using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_L12.Model
{
    public class Products
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"{Name}: {Price:0.00}$";
        }
    }
}
