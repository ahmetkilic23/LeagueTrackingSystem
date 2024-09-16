using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Entity
{
    public class TeamResult
    {
        public int Id { get; set; }
        public int TeamSeasonId { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lose { get; set; }

        //-----------------------------------
        public TeamSeason TeamSeason { get; set; }
    }
}