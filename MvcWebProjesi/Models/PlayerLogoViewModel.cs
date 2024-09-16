using MvcWebProjesi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Models
{
    public class PlayerLogoViewModel
    {
        public string Logo { get; set; }
        public string TeamName { get; set; }
        public Player Player { get; set; }
    }
}