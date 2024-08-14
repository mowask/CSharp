using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L10
{
    internal class StudentResultComparer : IComparer<Student>
    {
        public int Compare (Student x, Student y)
        {
            // return x-y

            if (x.Result < y.Result) return -1;
            if (x.Result > y.Result) return 1;
            return 0;
        }
    }
}
