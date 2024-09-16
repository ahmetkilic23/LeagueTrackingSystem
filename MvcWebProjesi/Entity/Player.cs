using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Entity
{
    public class Player
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string PlayerName { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        public int TeamId { get; set; }
        //-----------------------------------------
        public Team Team { get; set; }
        public List<PlayerAttribute> PlayerAttributes { get; set; }
    }
}