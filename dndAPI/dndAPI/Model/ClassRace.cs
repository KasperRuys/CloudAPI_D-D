using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dndAPI.Model
{
    public class ClassRace
    {
        //Joint class voor Classes en Races
        //Dit is nodig voor een veel op veel relatie
        public int ClassID { get; set; }
        public Class Class { get; set; }


        public int RaceID { get; set; }
        public Race Race { get; set; }
    }
}
