using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L8
{
    internal class Scientist : Empoloyee
    {
        string _scientificDirection;
        public Scientist(string fName, string lName, DateTime date, double salary, string direction) : base(fName, lName, date, salary)
        {
            _scientificDirection = direction;
        }

        public void ShowScientist()
        {
            Console.WriteLine($"Ученый. Научное направление: {_scientificDirection}");
        }
    }
}
