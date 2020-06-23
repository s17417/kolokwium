using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Models
{
    public class Team
    {
        [Key]
        public int IdTeam { get; set; }
        [Required]
        [MaxLength(30)]
        public string TeamName { get; set; }

        [Required]
        public int MaxAge { get; set; }

        public List<Championship_Team> Championship_Teams { get; set; }
        public List<Player_Team> Player_Teams { get; set; }


    }
}
