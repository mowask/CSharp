using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_L3_6
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public bool IsMarried { get; set; }


        public override string ToString()
        {
            return $"{Name}, {Age}, {Gender}, {(IsMarried ? "Married" : "Not Married")}";
        }
    }
}
