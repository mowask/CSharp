using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L4
{
    internal class Student
    {
        int _studentID;
        string _firstName = "John";
        string _lastName = "Doe";
        string _group;

        public void Print()
        {
            Console.WriteLine($"Студент {_firstName} {_lastName}");
        }
    }
}
