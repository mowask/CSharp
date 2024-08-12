using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L9
{
    internal class Ship: Transport
    {
        int _number;
        // конструктор базового класа
        public Ship(string name, int _number) : base(name, _number) { }
        public override int Number
        {
            get { return _number; }
            set
            {
                if (value > 10000 && value <= 100000)
                    _number = value;
            }
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} номер {_number} плывет");
        }
    }
}
