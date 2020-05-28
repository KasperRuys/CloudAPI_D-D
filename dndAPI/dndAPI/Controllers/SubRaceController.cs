using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dndAPI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dndAPI.Controllers
{
    [Route("api/Subrace")]
    [ApiController]
    [Authorize]
    public class SubRaceController : ControllerBase
    {
        MyDbContext ctx;
        public SubRaceController(MyDbContext context)
        {
            this.ctx = context;
        }

        [Route("[action]")]
        [HttpGet]
        public List<SubRace> GetSubracesByRaceID(int RaceID, /*string RaceName, string SubRaceName,*/ int? page = 0, string sort = "SubRaceName", int length = 2, string dir = "asc")
        {
            //Race ID 4, length 4 = 4 subraces van Elf

            IQueryable<SubRace> query = ctx.SubRaces;
            var race = ctx.Races
                              .SingleOrDefault(d => d.RaceID == RaceID);
            query = query.Where(d => d.Race == race);
            if (dir == "asc")
            {
                query = query.OrderBy(d => d.SubRaceName);
            }
            else if (dir == "desc")
            {
                query = query.OrderByDescending(d => d.RaceID);
            }
            if (page.HasValue)
            {
                query = query.Skip(page.Value * length);
            }
            
            query = query.Take(length);
            return query.ToList();

        }

        [HttpGet]
        public IActionResult Index()
        {
            IList<SubRace> subraces = ctx.SubRaces.Include(c => c.Race).ToList();

            return Ok(subraces);
        }
        
    
           [Route("[action]/{id}")]
           [HttpGet]
           public IActionResult Races(int id)
           {
               if (id == 0)
               {
                   return Redirect("/Subrace");
               }

               Race theRace = ctx.Races.Include(c => c.SubRaces).Single(c => c.RaceID == id);


               return Ok(theRace.SubRaces);
           }

           [Route("[action]/{id}")]
           [HttpGet]
           public IActionResult Subraces(int id)
           {
               if (id == 0)
               {
                   return Redirect("/Subrace");
               }

               SubRace theSubrace = ctx.SubRaces.Include(c => c.Race).Single(c => c.Id == id);


               return Ok(theSubrace);
           }





           // POST: api/Default
           [Route("[action]")]
           [HttpPost]
           public IActionResult AddSubRace([FromBody] SubRace addSubRace)
           {
               Race newRace = ctx.Races.Single(s => s.RaceID == addSubRace.RaceID);

               SubRace newSubRace = new SubRace
               {
                   SubRaceName = addSubRace.SubRaceName,
                   SubraceFeatures = addSubRace.SubraceFeatures,
                   RaceID = addSubRace.RaceID
               };
               ctx.SubRaces.Add(newSubRace);
               ctx.SaveChanges();
               return Ok(addSubRace);

               /* ctx.SubRaces.Include(c => c.Race).ToList().Add(SubRace);
                ctx.SubRaces.Add(SubRace);
                ctx.SaveChanges();
                return Ok(SubRace);*/
        }

        [Route("[action]")]
        [HttpPut]
        public IActionResult UpdateSubRace([FromBody] SubRace updateSubRace)
        {
            /*
             * {
                "id": #, Subrace id you want to change
                "subRaceName": "NewName", Subrace new name 
                "subraceFeatures": "newFeatures", subrace new features
                "raceID": 2 ID of the race of the new subrace
}
             */
            Race newRace = ctx.Races.Single(s => s.RaceID == updateSubRace.RaceID);
            var subrace = ctx.SubRaces.Find(updateSubRace.Id);
            if (subrace == null)
            {
                return NotFound();
            }
            else
            {
                subrace.Id = updateSubRace.Id;
                subrace.SubRaceName = updateSubRace.SubRaceName;
                subrace.SubraceFeatures = updateSubRace.SubraceFeatures;
                subrace.Race = newRace;
                ctx.SaveChanges();
                return Ok(subrace);
            }
        }
        // PUT: api/Default/5
        /* [HttpPut("{id}")]
         public IActionResult Put(int id, [FromBody] SubRace updatedSubRace)
         {
             var subrace = ctx.SubRaces.Find(id);
             if (subrace == null)
             {
                 return NotFound();
             }
             else
             {
                 subrace.SubRaceName = updatedSubRace.SubRaceName;
                 subrace.SubraceFeatures = updatedSubRace.SubraceFeatures;
                 //subrace.Race = updatedSubRace.Race;
                 ctx.SaveChanges();
                 return Ok(subrace);
             }

         }*/




        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSubRace(int id)
        {
            SubRace subrace = ctx.SubRaces.Find(id);
            if (subrace != null)
            {
                ctx.SubRaces.Remove(ctx.SubRaces.Find(id));
                ctx.SaveChanges();
                return Ok("Deleted subrace with ID " + id);
            }
            return NotFound("No subrace found with ID: " + id);
        }
        

    }
}