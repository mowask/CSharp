using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_m06
{
    internal class Kettle : Device
    {
        public Kettle() { }
        public Kettle(string name) : base(name) { }
        public Kettle(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Kettle sound: whish");
        }
        public override void Show()
        {
            base.Show();
        }
        public override void Description()
        {
            base.Description();
        }
       

    }
}
