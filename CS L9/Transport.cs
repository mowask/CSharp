using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L9
{
    abstract class Transport
    {
        public string Name { get; }
        public abstract int Number { get; set; }
        public Transport (string name, int number)
        {
            Name = name;           
            Number = number;
        }
        public abstract void Move();
    }
}
