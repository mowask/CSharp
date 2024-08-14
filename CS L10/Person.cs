using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L10
{
    internal class Person : IComparable
    {
        public string Name { get;}
        public int Age { get; set; }
        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public int CompareTo (object o)
        {
            if (o is Person)
            {
                return Name.CompareTo ((o as Person).Name);
            }
            throw new ArgumentException("Некоректное значение параметра");
        }

    }
}
