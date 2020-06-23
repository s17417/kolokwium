using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.DTO
{
    public class NewPlayerDTO
    {
        [Required]
        [MaxLength(30)]
        public string firstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string lastName { get; set; }
        [Required]
        public DateTime birthdate { get; set; }
        [Required]
        public int numOnShirt { get; set; }

        [MaxLength(300)]
        public string Comment { get; set; }


    }
}
