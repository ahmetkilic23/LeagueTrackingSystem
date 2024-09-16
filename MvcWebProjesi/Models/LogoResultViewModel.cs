using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Models
{
    public class LogoResultViewModel
    {
        public string Logo { get; set; }
        public string TeamName { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lose { get; set; }

        public int? Count { get; set; }
    }
}