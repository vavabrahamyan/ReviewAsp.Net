using System.Collections.Generic;
using System.Data.Entity;

namespace FilterApp.Models
{
    public class SoccerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
    public class SoccerDbInitalizer : DropCreateDatabaseAlways<SoccerContext>
    {
        protected override void Seed(SoccerContext context)
        {
            Team t1 = new Team { Name = "Barcelona" };
            Team t2 = new Team { Name = "Real Madrid" };
            context.Teams.Add(t1);
            context.Teams.Add(t2);
            context.SaveChanges();
           
            Player pl1 = new Player { Name = "Messi", Age = 33, Position = "attack", Team = t1 };
            Player pl2 = new Player { Name = "Ronaldo", Age = 36, Position = "attack", Team = t2 };
            Player pl3 = new Player { Name = "Chavi", Age = 39, Position = "midfielder", Team = t1 };
            Player pl4 = new Player { Name = "Bale", Age = 30, Position = "midfielder", Team = t2 };
            Player pl5 = new Player { Name = "Neymar", Age = 27, Position = "attack", Team = t1 };
            Player pl6 = new Player { Name = "Rodriges", Age = 31, Position = "midfielder", Team = t2 };
            context.Players.AddRange(new List<Player> { pl1, pl2, pl3, pl4, pl5, pl6 });
            context.SaveChanges();
        }
    }
}