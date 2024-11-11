using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_08_2.Models
{
    internal class Sale
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Employee Employee { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; }


        public override string ToString()
        {
            return $"{Id}, {Product}, {Employee}, {CustomerName}, {Quantity}";
        }

        public static Sale FromString(SqlDataReader reader) 
        {
            return new Sale
            {
                Id = Convert.ToInt32(reader[0].ToString()),
                Employee = Employee.FromString(reader[1].ToString(), reader[2].ToString(), reader[3].ToString()),
                Product = Product.FromString(reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                                            reader[7].ToString(), reader[8].ToString(), reader[9].ToString()),
                CustomerName = reader[10].ToString(),
                Quantity = Convert.ToInt32(reader[11].ToString()),
            };
        }

    }
}
