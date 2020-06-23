using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Models
{
    public class Player_Team
    {
        [ForeignKey("Player")]
        public int IdPlayer { get; set; }
        public Player Player { get; set; }

        [ForeignKey("Team")]
        public int IdTeam { get; set; }
        public Team Team { get; set; }

        [Required]
        public int NumOfShirt { get; set; }

        [MaxLength(300)]
        public string Comment { get; set; }


    }
}
