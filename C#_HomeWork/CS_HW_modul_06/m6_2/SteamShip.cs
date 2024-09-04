using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_m06
{
    internal class SteamShip : Device
    {
        public SteamShip() { }
        public SteamShip(string name) : base(name) { }
        public SteamShip(string name, string description) : base(name, description) { }

        public override void Sound( )
        {
            Console.WriteLine("Steamship sound: tutu");
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
