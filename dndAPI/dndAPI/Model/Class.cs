using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace dndAPI.Model
{
    public class Class
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [StringLength(60, ErrorMessage ="Name can't be longer than 60 chars")]
        public string ClassName { get; set; }
        [Required]
        [StringLength(400, ErrorMessage = "The Requirements can only be 400 characters long")]
        public string ClassRequirements { get; set; }

        [Range(4, 20, ErrorMessage = "Hit dice ranges from 4 to 20")]
        public int HitDie { get; set; }



      //  public IList<ClassRace> ClassRaces { get; set; } 

      /*  [JsonIgnore]
        public ICollection<Race> Races { get; set; }*/

        // public Race raceName { get; set; }

        // public int RaceID { get; set; }

        //   public Race Race { get; set; }
    }
}
