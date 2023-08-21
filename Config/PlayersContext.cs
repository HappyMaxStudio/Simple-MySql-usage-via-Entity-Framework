using DatabaseUsage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseUsage.Config
{
    internal class PlayersContext : DbContext
    {
        public DbSet<FootballPlayer> FootballPlayers => Set<FootballPlayer>();
        public PlayersContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\Vladimir\\Desktop\\Projects\\Тестовые\\DatabaseUsage\\players.db");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Warning);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
        }
    }
}
