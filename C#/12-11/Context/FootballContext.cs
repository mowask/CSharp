using L_12_11.Models;
using L_12_11.Models;
using Microsoft.EntityFrameworkCore;

namespace L_12_11.Context
{
    public class FootballContext: DbContext
    {
        public FootballContext ()
        {
            Database.EnsureCreated ();
        }


        public DbSet<League> League { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Football.db");
        }
    }
}
