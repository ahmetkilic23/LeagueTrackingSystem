using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Entity
{
    public class PlayerAttribute
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int Age { get; set; }
        public int Rating { get; set; }
        public double PlayerValue { get; set; } 
        public int TeamSeasonId { get; set; }
        //----------------------------------------
        public Player Player { get; set; }
        //public TeamSeason TeamSeason { get; set; }
    }
}