using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_20_LinqToSQL.Models
{
    [Table(Name = "Authors")]
    public class Authors
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column]
        public string FirstName { get; set; }
        [Column]
        public string LastName { get; set; }
    }
}
