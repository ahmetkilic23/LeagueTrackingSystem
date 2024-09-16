using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Entity
{
    public class BudgetRating
    {
        public int Id { get; set; }
        public int TeamSeasonId { get; set; }
        public int TeamRating { get; set; }
        public float TeamBudget { get; set; }

        //-------------------------------------------
        public TeamSeason TeamSeason { get; set; }
    }
}