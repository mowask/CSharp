using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_m06
{
    internal class Microwave : Device
    {
        public Microwave() { }
        public Microwave(string name) : base(name) { }
        public Microwave(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Microwave sound: hum");
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
