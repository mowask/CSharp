using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L9
{
    internal class Cashier : Employee, Iworker
    {
        bool isWorking = true;
        public bool IsWorking 
        {
            get
            {
                return IsWorking;
            }
        }
        public string Work()
        {
            return "Принимаю оплату за товар!";
        }
    }
}
