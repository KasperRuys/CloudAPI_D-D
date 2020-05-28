using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace dndAPI.Model
{
    public class Race
    {
        public int RaceID { get; set; }

        [Required]
        public string RaceName { get; set; }

        [Required]
        [StringLength(200)]
        public string RaceFeatures { get; set; }

       // [JsonIgnore]
        //public ICollection<Class> Classes { get; set; }

        [JsonIgnore]
        public IList<SubRace> SubRaces { get; set; }



      //  public List<ClassRace> ClassRaces { get; set; }
    }
}

