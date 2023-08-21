using DatabaseUsage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseUsage.Config
{
    internal class PlayerConfiguration:IEntityTypeConfiguration<FootballPlayer>
    {
        public void Configure(EntityTypeBuilder<FootballPlayer> builder)
        {
            builder.HasData(
                new FootballPlayer(1, "Joe", "Burrow", "Quarterback", "Bengals", 25, 4569, 0, 331),
                new FootballPlayer(2, "Greg", "Dulcich", "Tight End", "Broncos", 22, 0, 331, 30),
                new FootballPlayer(3, "Justin", "Jefferson", "Wide Receiver", "Vikings", 24, 0, 1780, 110),
                new FootballPlayer(4, "Brian", "Robinson Jr.", "Running Back", "Commanders", 23, 0, 178, 685),
                new FootballPlayer(5, "Mike", "Evans", "Wide Receiver", "Buccaneers", 29, 0, 1110, 54),
                new FootballPlayer(6, "Gerald", "Everett", "Tight End", "Chargers", 28, 0, 734, 12),
                new FootballPlayer(7, "Zonovan", "Knight", "Running Back", "Jets", 21, 0, 245, 554),
                new FootballPlayer(8, "Russell", "Wilson", "Quarterback", "Broncos", 34, 3456, 0, 277),
                new FootballPlayer(9, "Alec", "Pierse", "Wide Receiver", "Colts", 23, 0, 593, 5),
                new FootballPlayer(10, "Evan", "Engram", "Tight End", "Jaguars", 24, 0, 1780, 110)
                );
            builder.Ignore(x => x.College);
            builder.Property(x => x.Team).HasColumnName("Current Team");
            builder.Property(x => x.Name).IsRequired();
            builder.HasIndex(x => new { x.Name, x.Surname });
            builder.Property(x => x.YearsPro).HasDefaultValue(1);
            builder.Property(x => x.Name).HasMaxLength(15);
            builder.Property(x => x.Surname).HasMaxLength(15);
        }
    }
}
