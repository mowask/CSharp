using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCs_11_11.Models;

namespace WpfCs_11_11.Repositories
{
    public class SalesRepository
    {
        private readonly SqlConnection _connection;

        public SalesRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public ObservableCollection<Sale> getAll()
        {
            var list = new ObservableCollection<Sale>();
            string selectString = @"GetSales";
            var cmd = new SqlCommand(selectString, _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    {
                        list.Add(Sale.FromString(reader));
                    }
                }
            }
            return list;
        }

        public int Insert(Sale sale)
        {
            string insertString = $"INSERT INTO Sales (ProductId, EmployeeId, CustomerName, Quantity) " +
                $"VALUES (@ProductId, @EmployeeId, @CustomerNAme, @Quantity)";
            SqlCommand cmd = new SqlCommand(insertString, _connection);

            cmd.Parameters.Add(new SqlParameter(@"ProductId", System.Data.SqlDbType.Int))
                .Value = sale.Product.Id;

            cmd.Parameters.Add(new SqlParameter(@"EmployeeId", System.Data.SqlDbType.Int))
                .Value = sale.Employee.Id;

            cmd.Parameters.Add(new SqlParameter(@"CustomerNAme", System.Data.SqlDbType.NVarChar))
                .Value = sale.CustomerName;

            cmd.Parameters.Add(new SqlParameter(@"Quantity", System.Data.SqlDbType.Int))
                .Value = sale.Quantity;

            return cmd.ExecuteNonQuery();

        }
    }
}
