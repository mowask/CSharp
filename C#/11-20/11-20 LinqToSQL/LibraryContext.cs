using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _11_20_LinqToSQL.Models;

namespace _11_20_LinqToSQL
{
    public class LibraryContext : DataContext
    {
        public Table<Books> Books;
        public Table<Authors> Authors;

        public LibraryContext(string connectionString) : base(connectionString) { }


    }
}
