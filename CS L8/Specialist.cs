using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L8
{
    internal class Specialist : Empoloyee
    {
        string _qualification;
        public Specialist(string fName, string lName, DateTime date, double salary, string qualification) : base(fName, lName, date, salary)
        {
            _qualification = qualification;
        }

        public void ShowSpecialist() {
            Console.WriteLine($"Специалист. Квалификация: {_qualification}");
        }
    }
}
