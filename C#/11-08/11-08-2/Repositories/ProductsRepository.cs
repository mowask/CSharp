using _11_08_2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_08_2.Repositories
{
    internal class ProductsRepository
    {
        private readonly SqlConnection _connection;

        public ProductsRepository (SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Product> getAll()
        {
            var list = new List<Product>();
            string selectString = @"SELECT * FROM Products";
            var cmd = new SqlCommand(selectString, _connection);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    {
                        list.Add(Product.FromString(
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            reader[4].ToString(),
                            reader[5].ToString()));
                    }
                }
            }
            return list;
        }

    }
}
