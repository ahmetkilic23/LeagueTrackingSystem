using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Entity
{
    public class TeamSeason
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int SeasonId { get; set; }
        //--------------------------------------
        public Season Season { get; set; }
        public Team Team { get; set; }
        //public List<Team> Teams  { get; set; }
        //public List<Season> Seasons { get; set; }
    }
}