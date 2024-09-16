using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Entity
{
    public class Match
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int? AwayTeamId { get; set; }
        [MaxLength(7)]
        public string Result { get; set; }
        public int Week { get; set; }
        public int SeasonId { get; set; }

        //------------------------------------
        [ForeignKey("HomeTeamId")]
        public Team HomeTeam { get; set; }
        [ForeignKey("AwayTeamId")]
        public Team AwayTeam { get; set; }
        public Season Season { get; set; }
    }
}