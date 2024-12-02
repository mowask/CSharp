using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeSupplies_disconectedMode.Models;

namespace OfficeSupplies_disconectedMode.Repositories
{
    public class ProductsRepository
    {
        private readonly SqlConnection _connection;

        public ProductsRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public ObservableCollection<Products> getAll()
        {
            var list = new ObservableCollection<Products>();
            string selectString = @"SELECT * FROM Products";
            var cmd = new SqlCommand(selectString, _connection);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    {
                        list.Add(Products.FromString(
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

        public int Insert(Products prod)
        {
            string insertString = $"INSERT INTO Products (ProductName, ProductType, Cost, Price, Quantity) VALUES (@ProductName, @ProductType,@Cost, @Price, @Quantity)";
            SqlCommand cmd = new SqlCommand(insertString, _connection);

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@ProductName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = prod.ProductName
            });

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@ProductType",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = prod.ProductType
            });

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Cost",
                SqlDbType = System.Data.SqlDbType.Decimal,
                Value = prod.Cost
            });

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Price",
                SqlDbType = System.Data.SqlDbType.Decimal,
                Value = prod.Price
            });

            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Quantity",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = prod.Quantity
            });

            return cmd.ExecuteNonQuery();
        }
    }
}
