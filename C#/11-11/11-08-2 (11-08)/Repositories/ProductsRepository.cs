﻿using _11_08_2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
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

        public int Insert(Product prod)
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
