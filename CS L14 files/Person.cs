using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L14_Files
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; } = "n/a";
        public int Age { get; set; } = 18;
        public Company _company;

        public Person() { }
        public Person (string name, int age, Company company)
        {
            Name = name;
            Age = age;
            _company = company;
        }

        public override string ToString()
        {
            return $"{Name} {Age}: {_company.Name}";
        }

    }
}
