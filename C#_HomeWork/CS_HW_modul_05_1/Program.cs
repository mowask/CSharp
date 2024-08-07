using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_modul_05_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       
            Magazine magazine = new Magazine { 
                Name = "Animal Planet", 
                Year = 1967, 
                Description = "Animals", 
                Telephone = "555-50505", 
                Email= "Planeta@gmail.com",
                EmployeesNumber = 90,
            };  
            magazine.Print();
            Console.WriteLine();            
            magazine = magazine - 15;
            Console.WriteLine(magazine.EmployeesNumber);
            magazine = magazine - 150;
            Console.WriteLine(magazine.EmployeesNumber);
            magazine = magazine + 100;
            Console.WriteLine(magazine.EmployeesNumber);

            Console.WriteLine(Equals(magazine.EmployeesNumber, 100)) ;
            Console.WriteLine(magazine.EmployeesNumber == 90) ;
            Console.WriteLine(magazine.EmployeesNumber != 90) ;
            Console.WriteLine(magazine.EmployeesNumber <  90) ;
            Console.WriteLine(magazine.EmployeesNumber >  90) ;

            Console.ReadKey();
        }
    }
}
