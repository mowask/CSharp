using _11_20_2_DBCoutries.Models;
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

            //              2
            // DisplayAllCountries(db);
            // DisplayNameCountries(db);
            // DisplayCapital(db);
            // DisplayEuropianCountries(db);
            // DisplayCountriesAreaMore(db);
            // DisplayCoutriesMore5MResidentsOfCapital(db);

            //              3
            // Capitals_with_a_p(db);
            // Capitals_starts_with_k(db);
            // DisplayCountriesAreaBetween(db);
            // DisplayCountriesPopulationMore(db);

            //              4
            // Top5AreaCountries(db);
            // Top5ResidentsCapitals(db);
            // BigestAreaCountry(db);
            // Top1ResidentsCapital(db);
            // SmallestEuropeanCountry(db);
            // AvgAreaEuropeCountry(db);
            // CountCountries(db);
            // MaxCountriesContinent(db);
            // CountCountriesContinent(db);


        } 

        private static void CountCountriesContinent(CountriesContex db)
        {
            var countries = db.Countries.GroupBy(c => c.Continent).
                                   Select(k => new { continent = k.Key, count = k.Count() });
            foreach (var c in countries) 
                Console.WriteLine($"Continent: {c.continent} - {c.count} countries:");
        }

        private static void MaxCountriesContinent(CountriesContex db)
        {
            var continent =  db.Countries.GroupBy(c => c.Continent).OrderByDescending(k => k.Count()).First();            
                Console.WriteLine(continent.Key + " - " + continent.Count());
        }

        private static void CountCountries(CountriesContex db)
        {
            var countries = db.Countries;
            Console.WriteLine(countries.Count());
        }

        private static void AvgAreaEuropeCountry(CountriesContex db)
        {
            var country = db.Countries.Where(c => c.Continent == "Europe").Average(c => c.Area);
            Console.WriteLine($"Average European countries area  - {country}");
        }

        private static void SmallestEuropeanCountry(CountriesContex db)
        {
            var country = db.Countries.Where(c => c.Continent == "Europe").OrderBy(c => c.Area).First();                       
            Console.WriteLine($"Smallest European Country is {country.CountryName} with area {country.Area}");
            
        }

        private static void Top1ResidentsCapital(CountriesContex db)
        {
            var countries = from c in db.Countries
                            orderby c.CapitalResidents descending
                            select new { c.CountryName, c.CapitalName, c.CapitalResidents };

            foreach (var c in countries.Take(1))
                Console.WriteLine(c);
        }

        private static void BigestAreaCountry(CountriesContex db)
        {
            var countries = from c in db.Countries
                            orderby c.Area descending
                            select new { c.CountryName, c.Area };

            foreach (var c in countries.Take(1))
                Console.WriteLine(c);
        }

        private static void Top5ResidentsCapitals(CountriesContex db)
        {
            var countries = from c in db.Countries
                            orderby c.CapitalResidents descending
                            select new { c.CountryName, c.CapitalName, c.CapitalResidents };

            foreach (var c in countries.Take(5))
                Console.WriteLine(c);
        }

        private static void Top5AreaCountries(CountriesContex db)
        {
            var countries = from c in db.Countries
                            orderby c.Area descending
                            select new {c.CountryName, c.Area};

            foreach (var c in countries.Take(5)) 
                Console.WriteLine(c);
        }

        private static void DisplayCountriesPopulationMore(CountriesContex db)
        {
            var pop = decimal.Parse(Console.ReadLine());  
            var countries = from c in db.Countries
                            where c.Population > pop
                            select new { c.CountryName, c.Population };

            foreach (var c in countries)
                Console.WriteLine(c);
        }

        private static void DisplayCountriesAreaBetween(CountriesContex db)
        {
            // var areaMin = decimal.Parse(Console.ReadLine());
            // var areaMax = decimal.Parse(Console.ReadLine()); 
            var areaMin = 100000;
            var areaMax = 500000; 
            
            var countries = from c in db.Countries
                            where c.Area > areaMin && c.Area < areaMax
                            select new { c.CountryName, c.Area };

            foreach (var c in countries)
                Console.WriteLine(c);
        }

        private static void Capitals_starts_with_k(CountriesContex db)
        {
            // var countries = db.Countries.Where(c => c.CapitalName[0].Equals("k"));
            var countries = db.Countries.Where(c => c.CapitalName.StartsWith("k"));
            foreach (var c in countries)
                Console.WriteLine(c.CapitalName);
        }

        private static void Capitals_with_A_P(CountriesContex db)
        {
            var countries = db.Countries.Where(c => c.CapitalName.Contains("a") && c.CapitalName.Contains("p"));
            foreach (var c in countries)
                Console.WriteLine(c.CapitalName);
        }

        private static void DisplayCoutriesMore5MResidentsOfCapital(CountriesContex db)
        {
            var countries = db.Countries.Where(c => c.CapitalResidents > 5000000);
            foreach (var c in countries)
                Console.WriteLine(c.CapitalName);
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
