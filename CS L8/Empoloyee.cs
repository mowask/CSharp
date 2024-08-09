using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L8
{
    public class Empoloyee : Human
    {
        double _salary;
        public Empoloyee () : base ()       //  sealed
        { 
            _salary = 0;
        }
        public Empoloyee( string fName, string lName ) : base( fName, lName ) { }
        public Empoloyee( string fName, string lName, DateTime date ) : base( fName, lName, date ) { }
        public Empoloyee( string fName, string lName, double salary ) : base( fName, lName )   
        {
            _salary = salary;
        }
        public Empoloyee( string fName, string lName, DateTime date, double salary ) : base( fName, lName, date ) { _salary = salary; }

        public override string ToString()
        {
            return base.ToString() + $"\nЗаработная плата: {_salary} руб.";
        }

        public override void Print ()
        {
            // base.Print() ;
             Console.WriteLine($"\nЗаработная плата: {_salary} руб.");
            //Console.WriteLine(this);
            
        }

    }
}
