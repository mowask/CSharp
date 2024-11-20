using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_20_2_DBCoutries
{
    internal class Program
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        static void Main(string[] args)
        {
            CountriesContex db = new CountriesContex(ConnectionString);

           // DisplayAllCountries(db);
            //DisplayNameCountries(db);
            //DisplayCapital(db);
            //DisplayEuropianCountries(db);
            DisplayCountriesAreaMore(db);



        }

        private static void DisplayCountriesAreaMore(CountriesContex db)
        {
            var area = decimal.Parse(Console.ReadLine());
            // var countries = db.Countries.Where(c => c.Area > area);

            var countries = from c in db.Countries
                            where c.Area > area
                            select new { c.CountryName, c.Area };

            foreach (var c in countries)
                Console.WriteLine(c);
        }

        private static void DisplayEuropianCountries(CountriesContex db)
        {
            var countries = db.Countries.Where(c => c.Continent == "Europe");
            foreach (var c in countries)
                Console.WriteLine(c);
        }

        private static void DisplayCapital(CountriesContex db)
        {
            var countries = db.Countries;
            foreach (var c in countries)
                Console.WriteLine(c.CapitalName);
        }

        private static void DisplayNameCountries(CountriesContex db)
        {
            var countries = db.Countries.Select(c => c.CountryName);
            foreach (var c in countries) 
                Console.WriteLine(c);
        }

         private static void DisplayAllCountries(CountriesContex db)
        {
            var countries = db.Countries;
            foreach (var c in countries) 
                Console.WriteLine(c);
        }


    }
}
