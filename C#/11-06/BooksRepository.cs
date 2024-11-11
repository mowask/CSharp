using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class BooksRepository
    {
        private readonly SqlConnection conn;

        public BooksRepository(SqlConnection connection)
        {
            conn = connection;
        }


        public string GetAll()
        {
            string allBooksData = "";
            //string getAllBooksString = "GetAllBooks";
            SqlCommand cmd = new SqlCommand("GetAllBooks", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    //allBooksData += rdr.GetName(i) + "\t\t ";
                    allBooksData += $"{rdr.GetName(i), -17} ";
                }
                allBooksData += "\n";

                while (rdr.Read())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        //allBooksData += rdr[i] + "\t";
                        allBooksData += $"{rdr[i], -17} ";
                    }
                    allBooksData += "\n";
                }
            }
            return allBooksData;            
        }


        public string GetBookById(int id)
        {
            string book = "";
            SqlCommand cmd = new SqlCommand("GetBooksById", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters
              .Add(new SqlParameter("@Id", System.Data.SqlDbType.Int))
              .Value = id;

            using (var rdr = cmd.ExecuteReader())
            {
                if (rdr.Read())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {                        
                        book += $"{rdr[i],-17} ";
                    }
                    book += "\n";
                }
            }
            return book;
        }


        public string GetBookByTitle(string text)
        {
            string books = "";
            SqlCommand cmd = new SqlCommand("GetBooksByTitle", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters
              .Add(new SqlParameter("@text", System.Data.SqlDbType.NVarChar))
              .Value = text;

            using (var rdr = cmd.ExecuteReader())
            {
                books = FormatBooksTable(rdr);
            }

            return books;
        }


        //public string InsertBooks ()
        //{
        //    string insertString = $"INSERT INTO Books (FirstName, LastName) VALUES (@FirstName, @LastName)";
        //    SqlCommand cmd = new SqlCommand(insertString, conn);
        //}



        public int GetBookCount() 
        {
            string selectSctring = "SELECT Count(*) FROM Books";
            SqlCommand cmd = new SqlCommand(@selectSctring, conn);
            //int count = (int) cmd.ExecuteScalar();
            //Console.WriteLine(count);
            //return count;
            return (int)cmd.ExecuteScalar();
        }

        private string FormatBooksTable (SqlDataReader reader)
        {
            var booksData = "";            
                for (int i = 0; i < reader.FieldCount; i++)
                    booksData += $"{reader.GetName(i), -17} ";
                booksData += "\n";

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)                                           
                        booksData += $"{reader[i], -17} ";                    
                    booksData += "\n";
                }            
            return booksData;           
        }

        public int InsertBook(int authorId, string title, int price, int pages)
        {
            SqlCommand cmd = new SqlCommand("InsertBook", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@authorId",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = authorId
            });

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@title",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = title
            });

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@price",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = price
            });

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@pages",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = pages
            });

            return cmd.ExecuteNonQuery();
        }


        public int DeleteBook(int id) 
        {           
            SqlCommand cmd = new SqlCommand("DeleteBook", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters
              .Add(new SqlParameter("@Id", System.Data.SqlDbType.Int))
              .Value = id;

            return cmd.ExecuteNonQuery();
        }

        public int UpdateBook(int id ,int authorId, string title, int price, int pages)
        {
            SqlCommand cmd = new SqlCommand("UpdateBook", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@id",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = id
            });

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@authorId",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = authorId
            });

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@title",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = title
            });

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@price",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = price
            });

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@pages",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = pages
            });

            return cmd.ExecuteNonQuery();
        }


    }
}
