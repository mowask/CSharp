using L_12_11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_12_11.Models
{
    [Table("Teams")]
    public class Teams
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int LeagueId { get; set; }
       

        public League League { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
