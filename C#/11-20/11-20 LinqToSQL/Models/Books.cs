using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_20_LinqToSQL.Models
{
    [Table(Name = "Books")]
    public class Books
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public int AuthorId { get; set; }
        [Column]
        public string Title { get; set; }
        [Column]
        public int? PRICE { get; set; }
        [Column]
        public int? PAGES { get; set; }

    }
}
