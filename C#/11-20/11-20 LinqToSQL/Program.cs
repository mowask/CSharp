using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Linq;
using _11_20_LinqToSQL.Models;

namespace _11_20_LinqToSQL
{
    internal class Program
    {
        //static SqlConnection _connection = null;

        static string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        

        static void Main(string[] args)
        {           
            //var db = new DataContext (ConnectionString);
            //      =
            LibraryContext db = new LibraryContext (ConnectionString);

            var authors = db.Authors;
            //      =
            //var authors = db.GetTable<Authors>().Where(a => a.FirstName.StartsWith("d"));

            //foreach (var a in authors)            
            //    Console.WriteLine($"{a.Id} {a.FirstName} {a.LastName}");

            //Console.WriteLine();

            //var author = db.GetTable<Authors>().Where(a => a.FirstName.StartsWith("d")).FirstOrDefault();
            //Console.WriteLine($"{author.Id} {author.FirstName} {author.LastName}");



            //Authors author = db.GetTable<Authors>().FirstOrDefault();

            //author.FirstName = "Asic";
            //db.SubmitChanges();
            //Console.WriteLine(author.FirstName);


            //Authors newAuthors = new Authors()
            //{
            //    FirstName = "Frank",
            //    LastName = "Herbert"
            //};

            //db.GetTable<Authors>().InsertOnSubmit(newAuthors);
            //db.SubmitChanges();



            //Authors daleteAuthor = db.GetTable<Authors> ().Where(a => a.FirstName == "Frank").FirstOrDefault();

            //db.GetTable<Authors>().DeleteOnSubmit (daleteAuthor);
            //db.SubmitChanges ();


            //var authors = db.GetTable<Authors>();
            //foreach (var a in authors)
            //    Console.WriteLine($"{a.Id} {a.FirstName} {a.LastName}");


            //////////////////////////////////////////////////////////////////////


            var books = db.GetTable<Books>();

            var booksWithAuthors = from b in db.Books
                                   join a in db.Authors on b.AuthorId equals a.Id
                                   select new
                                   {
                                       BookTitle = b.Title,
                                       AuthorName = a.FirstName + " " + a.LastName
                                   };

            foreach (var b in booksWithAuthors)            
                Console.WriteLine(b.BookTitle + " " + b.AuthorName);

            //      =

            var booksWithAuthors2 = db.Books.Join(
                db.Authors,
                b => b.AuthorId,
                a => a.Id,
                (b, a) => new{
                    BookTitle = b.Title,
                    AuthorName = a.FirstName + " " + a.LastName
                    }
            );

            foreach (var b in booksWithAuthors2)
                Console.WriteLine(b.BookTitle + ": " + b.AuthorName);











        }
    }
}
