using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using _11_08_2.Repositories;


namespace _11_08_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = null;

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                conn = new SqlConnection(ConnectionString);
              
                conn.Open();
                if (conn.State == ConnectionState.Open)
                    Console.WriteLine("Connected to Database");

                ProductsRepository pr = new ProductsRepository(conn);
                var products = pr.getAll();

                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
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


            


        }
    }
}
