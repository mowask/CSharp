using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace hw_ado_net_m1_1_fruits
{
    internal class Program
    {                     

        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            SqlConnection _connection = new SqlConnection(connectionString);

            try
            {
            _connection.Open();
            if (_connection.State == ConnectionState.Open)
            {
                Console.WriteLine("Connected to Database");
            }

            VeganBase vb = new VeganBase(_connection);

            vb.GetAllProducts();

                //string select = @"SELECT * FROM Products";
                //SqlCommand cmd = new SqlCommand(select, _connection);
                //SqlDataReader reader = cmd.ExecuteReader();

                //for (int i = 0; i < reader.FieldCount; i++)
                //{
                //    Console.WriteLine(reader[i]);
                //}
                //while (reader.Read())
                //{
                //    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3] + " " + reader[4]);
                //}
                //reader.Close();





            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (_connection != null)
                    _connection.Close();
            }

        }
    }

    public class VeganBase
    {
        readonly SqlConnection _connection;

        public VeganBase(SqlConnection connection)
        {
            _connection = connection;
        }

        public string GetAllProducts() 
        {
            string prod = "";
            string select = @"SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(select, _connection);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Id   Name        V/F   Color    calories");
            while (reader.Read())
            {
                Console.WriteLine(reader[0]+ "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] + "\t" + reader[4]);
            }
            reader = cmd.ExecuteReader();

            return prod;
        }
    }
}
