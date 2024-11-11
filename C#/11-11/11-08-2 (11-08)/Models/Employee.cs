﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_08_2.Models
{
    internal class Employee
    {
        public int Id { get; set; }      
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName}";
        }
        public static Employee FromString(string id, string firstname, string lastname)
        {
            return new Employee()
            {
                Id = Convert.ToInt32(id),
                FirstName = firstname,
                LastName = lastname
            };


        }
    }
}
