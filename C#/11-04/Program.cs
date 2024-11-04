using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Data;
using System.Data.SqlClient;

namespace _04_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = null;
            conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;
                                        Initial Catalog = Library;
                                        Integrated Security = True;
                                        Connect Timeout = 30;
                                        Encrypt = False;");       

            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("Connected to Database");
            }


            //                      INSERT

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = @"INSERT INTO Authors VALUES('Roger', 'Zelazny')";
            //cmd.Connection = conn;

            //string insertString = @"INSERT INTO Authors VALUES('Roger', 'Zelazny')";
            //SqlCommand cmd = new SqlCommand(insertString, conn);
            //int count = cmd.ExecuteNonQuery();
            //Console.WriteLine(count);

            //string insertString = @"INSERT INTO Books VALUES('1', 'Zelazny biografy', '99', '3210')";
            //SqlCommand cmd = new SqlCommand(insertString, conn);
            //int count = cmd.ExecuteNonQuery();
            //Console.WriteLine(count);


            //                  READ


            //string selectString = @"SELECT * FROM Authors";
            //SqlCommand cmd = new SqlCommand(selectString, conn);
            //SqlDataReader rdr =  cmd.ExecuteReader();

            //while (rdr.Read())
            //{
            //    Console.WriteLine(rdr[0]);
            //    Console.WriteLine(rdr[1]);
            //    Console.WriteLine(rdr[2]);
            //    Console.WriteLine(rdr[0] + " " + rdr[1]+ " " + rdr[2]);
            //}
            //rdr.Close();

            Console.WriteLine();


            string selectString = @"SELECT * FROM books";
            SqlCommand cmd = new SqlCommand(selectString, conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine("Collum count= " + rdr.FieldCount);

            for (int i = 0; i < rdr.FieldCount; i++)
            {
                Console.Write(rdr.GetName(i) + " \t");
            }
            Console.WriteLine() ;
            while (rdr.Read())
            {
                //Console.WriteLine(rdr[0]);
                //Console.WriteLine(rdr[1]);
                //Console.WriteLine(rdr[2]);
                //Console.WriteLine(rdr[3]);
                //Console.WriteLine(rdr[4]);
                //Console.WriteLine(rdr[0] + ",\t " + rdr[1] + ",\t " + rdr[2]+ ",\t " + rdr[3] + ",\t " + rdr[4]);
                Console.WriteLine(rdr["id"] + ",\t " + rdr["AuthorId"] + ",\t " + rdr["title"]+ ", " + rdr[3] + ",\t " + rdr[4]);
            }
            rdr.Close();


            string selectCountString = @"SELECT COUNT(*) FROM Authors";
            SqlCommand cmd3 = new SqlCommand(selectCountString, conn);

            int authorsCount = (int) cmd3.ExecuteScalar();
            Console.WriteLine("authors Count = " + authorsCount);


            string selectMaxString = @"SELECT MAX(PRICE) FROM Books";
            SqlCommand cmd4 = new SqlCommand(selectMaxString, conn);
            int maxPrice = (int)cmd4.ExecuteScalar();
            Console.WriteLine("max price = " + maxPrice);


            conn.Close();
             
            Console.ReadKey();
        }
    }
}


