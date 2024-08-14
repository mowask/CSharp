using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L10
{
    internal class StudentDateComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {           
           return DateTime.Compare (x.DateOfBirth, y.DateOfBirth);
        }
    }
}
