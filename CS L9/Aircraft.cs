using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L9
{
    internal class Aircraft: Transport
    {
        // конструктор базового класа
        private int _number;
        public Aircraft(string name, int _number) : base(name, _number) { }
        public override int Number
        {
            get { return _number; }
            set
            {
                if (value > 1000 && value <= 9999)
                    _number = value;
            }
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} номер {_number} летит");
        }
       
    }
}
