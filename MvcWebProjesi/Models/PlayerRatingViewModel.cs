using MvcWebProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Models
{
    public class PlayerRatingViewModel
    {
        public PlayerLogoViewModel PLVM { get; set; }
        public PlayerAttribute PlayerAttributes { get; set; }
    }
}