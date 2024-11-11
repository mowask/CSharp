using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Data;
using System.Data.SqlClient;
using ConsoleApp1;
using System.Linq.Expressions;
using System.Configuration;

namespace _04_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = null;
            try
            {
                //conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;
                //                        Initial Catalog = Library;
                //                        Integrated Security = True;
                //                        Connect Timeout = 30;
                //                        Encrypt = False;");


                string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                conn = new SqlConnection(ConnectionString);

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connected to Database");
                }

                AuthorsRepository authorsRepository = new AuthorsRepository(conn);
                BooksRepository booksRepository = new BooksRepository(conn);

                //authorsRepository.Insert("Isaac", "Asimov");
                //authorsRepository.Insert("Arthur", "Clarke");
                //authorsRepository.Insert("Robert", "Heinlein");
                //authorsRepository.Insert("Aaa", "Bbb");

                var allAuthors = authorsRepository.GetAll();
                //Console.WriteLine(allAuthors);

               // booksRepository.InsertBook(3, "book7", 150, 333);

                booksRepository.GetAll();
                Console.WriteLine(booksRepository.GetAll());

                //booksRepository.DeleteBook(1005);
                //Console.WriteLine(booksRepository.GetAll());

                //Console.WriteLine(booksRepository.GetBookById(1));
                // Console.WriteLine(booksRepository.GetBookByTitle("gra"));

                //booksRepository.UpdateBook( 3 ,2, "Book3", 100, 333);
                //Console.WriteLine(booksRepository.GetAll());

                Console.WriteLine(booksRepository.GetBookCount());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally 
            {
                if (conn != null) 
                    conn.Close();
            }


           // AuthorsRepository authors = new AuthorsRepository(conn);

            //Console.WriteLine(authors.GetAll());
            //Console.WriteLine(authors.GetById(2));



            Console.ReadKey();

        }
    }
}