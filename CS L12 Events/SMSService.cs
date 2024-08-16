using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L12_Events
{
    internal class SMSService
    {
        public static void sendMessage ( string text)
        {
            Console.WriteLine ($"SMS: {text}\n");
        }
    }
}
