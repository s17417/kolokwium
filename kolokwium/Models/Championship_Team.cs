using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Models
{
    public class Championship_Team
    {
        [ForeignKey("Team")]
        public int IdTeam { get; set; }
        public Team Team { get; set; }

        [ForeignKey("Championship")]
        public int IdChampionship { get; set; }
        public Championship Championship { get; set; }

        [Required]
        public float Score { get; set; }



    }
}
