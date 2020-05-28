using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dndAPI.Model
{
    public class SubRace
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Only 50 characters allowed")]
        public string SubRaceName { get; set; }
        [Required]
        [StringLength(400, ErrorMessage = "Only 400 characters allowed")]
        public string SubraceFeatures { get; set; }
        public string Link { get; set; }


        public int RaceID { get; set; }
        public Race Race { get; set; }
    }
}
