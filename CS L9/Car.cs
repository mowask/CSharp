using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L9
{
    internal class Car : Transport
    {
        int _number;
        public Car(string name, int _number) : base(name, _number) { }
        public override int Number 
        {
            get { return _number;  }
            set { 
                if (value > 0 && value <=100) 
                    _number = value;                    
                }
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} номер {_number} едет");
        }
    }
}
