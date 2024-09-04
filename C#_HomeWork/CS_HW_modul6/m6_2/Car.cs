using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS_HW_m06
{
    internal class Car  : Device
    {
        public Car() { }
        public Car(string name) : base(name) { }
        public Car(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Car sound: beep");
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
