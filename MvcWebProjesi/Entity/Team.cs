using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Entity
{
    public class Team
    {

        public Team()
        {
            Players = new List<Player>();
        }

        public int Id { get; set; }
        [MaxLength(100)]
        public string TeamName { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        public bool IsActive { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }

        //--------------------------------------
        public List<Season> Seasons { get; set; }
        public List<Player> Players { get; set; }
        public List<BudgetRating> BudgetRatings { get; set; }
    }
}