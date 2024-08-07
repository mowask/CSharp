using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_modul_05_1
{
    internal class Magazine
    {
        
        public string Name { get; set; }
        public int  Year { get; set; }
        public string Description { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int EmployeesNumber { get; set; } = 0;
                       
        public void changeTelephone(string newTel)  { Telephone = newTel; }
        public void Print()
        {
            Console.WriteLine($"Title: {Name} \nTheme: {Description} \nsince: {Year}" +
                $"\nTel: {Telephone} \nEmail: {Email} \nEmployees: {EmployeesNumber}");
        }

        public static Magazine operator + (Magazine Emp, int n)
        {
            return new Magazine { EmployeesNumber = Emp.EmployeesNumber + n };
        }
        public static Magazine operator + (int m,  Magazine Emp)
        {
            return Emp + m;
        }
        public static Magazine operator - (Magazine Emp, int n)
        {
            if (n > Emp.EmployeesNumber)
            {
               Console.WriteLine("Error, no more emploees");
               return new Magazine { EmployeesNumber = 0 };
            }
            else 
                return new Magazine { EmployeesNumber = Emp.EmployeesNumber - n };
        }

        public override bool Equals(Object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator == (Magazine Emp, int num)
        {
            return Emp.Equals(num);
        }
        public static bool operator !=(Magazine Emp, int num)
        {
            return Emp.Equals(num);
        }
         public static bool operator > (Magazine Emp, int num)
        {
            return Emp.Equals(num);
        }
        public static bool operator < (Magazine Emp, int num)
        {
            return Emp.Equals(num);
        }



    }
}
