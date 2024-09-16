using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MvcWebProjesi.Models
{
    public class ApiModel
    {
        public string Rank { get; set; }
        public string Lose { get; set; }
        public string Win { get; set; }
        public string Play { get; set; }
        public string Point { get; set; }
        public string Team { get; set; }
    }
}