using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L10
{
    internal class StudentNameComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return String.Compare(x.Name, y.Name);

            //if (x.Name < y.Name) return -1;
            //if (x.Name > y.Name) return 1;
            //return 0;

        }
    }
}
