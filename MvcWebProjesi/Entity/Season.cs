using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Entity
{
    public class Season
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string SeasonYear { get; set; }
        [MaxLength(50)]
        public string SeasonName { get; set; }

        //---------------------------------------
        public List<TeamSeason> TeamSeasons { get; set; }
    }
}