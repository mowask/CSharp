using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L8
{
    public class Human
    {
        string _firstName;
        string _lastName;
        DateTime _birthday;

        public Human() : this ( "Unknow", "Unknow", new DateTime() ) {}
        public Human(string fName, string lName) : this (fName,lName, new DateTime())    { }
        public Human(string fName, string lName, DateTime date) {
            _firstName= fName;
            _lastName= lName;
            _birthday= date;
        }
        public override string ToString()
        {
            return $"\nФамилия: {_lastName}\nИмя: {_firstName}\nДень рождения: {_birthday.ToShortDateString()}";
        }

        public virtual void Print()
        {
            Console.WriteLine($"\nФамилия: {_lastName}\nИмя: {_firstName}\nДень рождения: {_birthday.ToShortDateString()}");
        }
    }
}
