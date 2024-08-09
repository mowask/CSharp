using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L8
{
    internal class Manager : Empoloyee
    {
        string _fiedActivity;
        public Manager(string fName, string lName, DateTime date, double salary, string activity): base (fName, lName, date, salary) 
        {
            _fiedActivity = activity;
        }

        public void ShowManager() {
            Console.WriteLine($"Менеджер. Сфера деятельности: {_fiedActivity}");
        }
    }
}
