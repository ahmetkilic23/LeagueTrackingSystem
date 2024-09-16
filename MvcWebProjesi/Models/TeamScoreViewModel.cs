using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Models
{
    public class TeamScoreViewModel
    {
        public string Score { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public string HomeLogo { get; set; }
        public string AwayLogo { get; set; }
        public int Week { get; set; }
    }
}