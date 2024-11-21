using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _11_20_2_DBCoutries.Models;

namespace _11_20_2_DBCoutries
{
    public class CountriesContex : DataContext
    {
        public Table<Country> Countries;
        public CountriesContex(string connectionString) :base (connectionString)         {        }
    }
}
