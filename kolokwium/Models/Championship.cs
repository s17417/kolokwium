using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Models
{
    public class Championship
    {
        [Key]
        public int IdChampionship { get; set; }
        [Required]
        [MaxLength(100)]
        public string OfficialName { get; set; }
        [Required]
        public int Year { get; set; }

        public List<Championship_Team> Championship_Teams { get; set; }
    }
}
