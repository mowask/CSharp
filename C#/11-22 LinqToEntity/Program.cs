using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_22_LinqToEntity
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var rand = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    int authorId, publisherId;
            //    using (var db = new LibraryEntities() )
            //    {
            //        int randCount = rand.Next(0, db.Authors.Count());
            //        authorId = db.Authors.OrderBy(a =>a.Id).Skip(randCount).Take(1).Select(a =>a.Id).FirstOrDefault();

            //        randCount = rand.Next(0, db.Publishers.Count());
            //        publisherId = db.Publishers.OrderBy(a => a.Id).Skip(randCount).Take(1).Select(a => a.Id).FirstOrDefault();
            //    }

            //    if (authorId == 0 || publisherId == 0) continue;

            //    var b = new Book()
            //    {
            //        Title = $"Book{i+1}",
            //        AuthorId = authorId,
            //        PRICE = i*100,
            //        PAGES = authorId*10,
            //        PublisherId = publisherId,

            //    };

            //    AddBook(b);
            //}




            //Author author = new Author()
            //{
            //    FirstName = "Fedor",
            //    LastName = "Tutchev"
            //};

            //Publisher publisher = new Publisher()
            //{
            //    PublisherName = "Iskra",
            //    Address = "SPB Petrova 11"
            //};      



            //// AddAuthor(author);
            //GetAllAuthors();
            //Console.WriteLine("=======================");

            //// AddPublisher(publisher);
            //GetAllPublishers();
            //Console.WriteLine("=======================");


            //GetAllBooks();



            /////////////////////////////////////////////////////////


            // GetAllBooksToLog();

            // GetAllBooksEager();

            GetAllBooksExplecit();


        }


        static void AddAuthor(Author author)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                db.Authors.Add(author);
                db.SaveChanges();
                Console.WriteLine("New author added:", author.LastName);
            }
        }

        static void GetAllAuthors()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var au = db.Authors.ToList();
                foreach (var a in au)
                    Console.WriteLine(a.FirstName + " " + a.LastName);
            }
        }


        static void AddPublisher(Publisher publisher)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                //var rand = new Random();
                //for (int i = 0; i < 10; i++)
                //{
                //    var p = new Publisher()
                //    {
                //        PublisherName = $"Publisher {i + 1}",
                //        Address = $"Moscow, Lenina {rand.Next(1, 99)}"
                //    };
                //}
                db.Publishers.Add(publisher);
                db.SaveChanges();
                Console.WriteLine("New author added:", publisher.PublisherName);
            }
        }

        static void GetAllPublishers()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var pub = db.Publishers.ToList();
                foreach (var p in pub)
                    Console.WriteLine(p.PublisherName + p.Address);
            }
        }


        static void AddBook(Book book)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                db.Books.Add(book);
                db.SaveChanges();
                Console.WriteLine("New author added:", book.Title);
            }
        }

        static void GetAllBooks()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var books = db.Books.Include("Author").Include("Publisher").ToList();
                foreach (var b in books)
                    Console.WriteLine($"{b.Id}{b.Title}" +
                        $"{b.Author.FirstName}{b.Author.LastName}" +
                        (b.Publisher == null ? "" : b.Publisher.PublisherName));
            }
        }


        /////////////////////////////////////////////////////////////////////////
        ///

        static void GetAllBooksLazy()   
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                db.Database.Log = LogDB;
                var books = db.Books.ToList();
                foreach (var b in books)
                    Console.WriteLine(b.Title + " " + b.Author.FirstName);


                // db.Database.Log = Console.WriteLine;
                // 1.    var books = db.Books.ToList();
                //       var books = db.Books.Where(b => b.Id < 10000).ToList();
                // 2.    foreach
                // 3.    db.Books.Load();
            }
        }


        static void LogDB(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void GetAllBooksEager()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                db.Database.Log = LogDB;
                var books = db.Books.Include("Author").ToList();
                foreach (var a in books)
                {
                    Console.WriteLine("Bool " + a.Title + " price: " + a.PRICE + " author: "
                        + a.Author.FirstName + a.Author.LastName);
                }
            }
        }

        static void GetAllBooksExplecit()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                db.Database.Log = LogDB;
                var books = db.Books.ToList();
                foreach (var book in books)
                {
                    db.Entry(book).Reference(b => b.Author).Load();
                    Console.WriteLine(book.Id +" " + book.Author.LastName);
                }
            }
        }





    }
}
