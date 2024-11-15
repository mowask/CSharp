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


                //  3
            vb.GetAllProducts();
                Console.WriteLine();
            vb.GetProductName();
                 Console.WriteLine();
            vb.GetColors();
                 Console.WriteLine();
            vb.GetMaxCalories();
                Console.WriteLine();
            vb.GetMinCalories();
                Console.WriteLine();
            vb.GetAvgCalories();
                Console.WriteLine();

                //  4

            vb.GetCountVegetables();
                Console.WriteLine();

            vb.GetCountFruits();
                Console.WriteLine();



                Console.ReadKey();

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

        public void GetAllProducts() 
        {            
            string select = @"SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(select, _connection);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Id   Name        V/F   Color    calories");
            while (reader.Read())
            {
                Console.WriteLine(reader[0]+ "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] + "\t" + reader[4]);
            }
            reader.Close();            
        }


        public void GetProductName()
        {            
            string select = @"SELECT Name FROM Products";
            SqlCommand cmd1 = new SqlCommand(select, _connection);
            SqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
                Console.Write(reader["Name"] + " ");
            reader.Close();
        }

        public void GetColors() 
        {            
            string select = @"SELECT Color FROM Products";
            SqlCommand cmd2 = new SqlCommand(select, _connection);
            SqlDataReader reader = cmd2.ExecuteReader();

            while (reader.Read())
                Console.Write(reader["Color"] + " ");
            reader.Close();
        }

        public void GetMaxCalories() 
        {            
            string select = @"SELECT MAX(Сalories) FROM Products";
            SqlCommand cmd3 = new SqlCommand(select, _connection);            

            int maxCalories = (int)cmd3.ExecuteScalar();
                Console.Write("maxCalories = " + maxCalories);                               
        }

        public void GetMinCalories() 
        {            
            string select = @"SELECT MIN(Сalories) FROM Products";
            SqlCommand cmd3 = new SqlCommand(select, _connection);            

            int minCalories = (int)cmd3.ExecuteScalar();
                Console.Write("maxCalories = " + minCalories);                               
        }

         public void GetAvgCalories() 
        {            
            string select = @"SELECT AVG(Сalories) FROM Products";
            SqlCommand cmd3 = new SqlCommand(select, _connection);            

            int avgCalories = (int)cmd3.ExecuteScalar();
                Console.Write("maxCalories = " + avgCalories);                               
        }

        //  4
         public void GetCountVegetables() 
        {            
            string select = @"SELECT Count(*) FROM Products WHERE Type = 'vegetable'";
            SqlCommand cmd3 = new SqlCommand(select, _connection);            

            int count = (int)cmd3.ExecuteScalar();
                Console.Write("vegetable = " + count);          
        }

        public void GetCountFruits() 
        {            
            string select = @"SELECT Count(*) FROM Products WHERE Type = 'fruit'";
            SqlCommand cmd3 = new SqlCommand(select, _connection);            

            int count = (int)cmd3.ExecuteScalar();
                Console.Write("vegetable = " + count);          
        }



    }
}
