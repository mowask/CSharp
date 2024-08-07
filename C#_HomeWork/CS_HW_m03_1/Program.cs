using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_m03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Website website = new Website { Name = "Cheese-cake.ru", Url = "https://cheese-cake.ru/", Description = "desserts", Ip = "185.178.208.178" };
            website.Print();
            Console.WriteLine();
            website.changeTheme("tastys");
            website.Print();
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.WriteLine();

            ///////////////////////////////////////////////////

            Magazine magazine = new Magazine
            {
                Name = "Animal Planet",
                Year = 1967,
                Description = "Animals",
                Telephone = "555-50505",
                Email = "Planeta@gmail.com",
                EmployeesNumber = 90
            };
            magazine.Print();
            Console.WriteLine();
            magazine.changeTelephone("880099777");
            magazine.Print();   
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.WriteLine();

            //////////////////////////////////////////////////
            
            Shop store = new Shop { Name = "Hommer's", Address =  "742 Evergreen terrace", Description = "donuts", 
                                     Telephone = "325-6753",
                Email = "Planeta@gmail.com"};
            store.Print();
            Console.WriteLine();
            store.changeTelephone("369-3048");
            store.Print();


            Console.ReadKey();
        }
    }
}
