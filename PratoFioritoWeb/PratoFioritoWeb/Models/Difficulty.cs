using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PratoFioritoWeb.Models
{
    public class Difficulty
    {
        public int id { get; set; }

        [Required]
        [Range(1, 999)]
        public int width { get; set; }

        [Required]
        [Range(1, 999)]
        public int height { get; set; }
    }
}
