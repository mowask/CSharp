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
using _11_08_2.Models;


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

                //ProductsRepository productsRepository = new ProductsRepository(conn);
                //productsRepository.Insert(new Models.Product()
                //{
                //    ProductName = "Milk",
                //    ProductType = "Diery",
                //    Cost = 10.00m,
                //    Price = 12.00m,
                //    Quantity = 1,
                //});             

                ProductsRepository pr = new ProductsRepository(conn);
                var products = pr.getAll();
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }


                var er = new EmployeeRepositories(conn);

                //er.Insert(new Employee()
                //{
                //    FirstName = "John",
                //    LastName = "Doe"
                //});

                List<Employee> lc = er.getAll();
                foreach (Employee e in lc)
                {
                    Console.WriteLine(e);
                }


                var sr = new SalesRepository(conn);
                sr.Insert(new Sale()
                {
                   
                });
                    
                List <Sale> sales =  sr.getAll();
                foreach (Sale s in sales)
                {
                    Console.WriteLine(s);
                }

                
                             

                Console.ReadKey();           


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
