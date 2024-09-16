using MvcWebProjesi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<BudgetRating> BudgetRatings { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerAttribute> PlayerAttributes { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamResult> TeamResults { get; set; }
        public DbSet<TeamSeason> TeamSeasons { get; set; }
    }
}