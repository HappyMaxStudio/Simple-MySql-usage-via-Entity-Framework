using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseUsage.Models
{
    internal class FootballPlayer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Position { get; set; }
        public string? Team { get; set; }
        public int Age { get; set; }
        public int PassingYards { get; set; }
        public int ReceivingYards { get; set; }
        public int RushingYards { get; set; }
        public int ScrimmageYards { get; private set; }
        public int YearsPro { get;set; }

        public string? College { get; set; }

        public FootballPlayer(int id, string name, string surname, string position, string team, int age,
            int passingYards, int receivingYards, int rushingYards)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Position = position;
            Team = team;
            Age = age;
            PassingYards = passingYards;
            ReceivingYards = receivingYards;
            RushingYards = rushingYards;
            ScrimmageYards = passingYards + rushingYards + receivingYards;
        }
    }
}
