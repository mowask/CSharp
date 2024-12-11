using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_12_11.Models
{
    [Table("League")]
    public class League
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public ICollection<Teams> Teams { get; set; }
    }
}
