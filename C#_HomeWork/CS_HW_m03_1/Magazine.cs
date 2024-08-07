using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_m03_1
{
    internal class Magazine
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int EmployeesNumber { get; set; } = 0;

        public void changeTelephone(string newTel) { Telephone = newTel; }
        public void Print()
        {
            Console.WriteLine($"Title: {Name} \nTheme: {Description} \nsince: {Year}" +
                $"\nTel: {Telephone} \nEmail: {Email}, \nEmployees: {EmployeesNumber}");
        }

        
    }
}
