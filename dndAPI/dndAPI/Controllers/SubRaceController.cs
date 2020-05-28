using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dndAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dndAPI.Controllers
{
    [Route("api/Subrace")]
    [ApiController]
    public class SubRaceController : ControllerBase
    {
        MyDbContext ctx;
        public SubRaceController(MyDbContext context)
        {
            this.ctx = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IList<SubRace> subraces = ctx.SubRaces.Include(c => c.Race).ToList();

            return Ok(subraces);
        }


        public List<SubRace> GetSubracesByRaceID(int SubRaceID, string RaceName, string SubRaceName, int? page = 0, string sort = "SubRaceName", int length = 2, string dir = "asc")
        {
            IQueryable<SubRace> query = ctx.SubRaces;
            var race = ctx.Races
                              .SingleOrDefault(d => d.RaceID == SubRaceID);
            if (!string.IsNullOrEmpty(SubRaceName))
            {
                query = query.Where(d => d.SubRaceName == SubRaceName);
            }
            /* if (!string.IsNullOrEmpty(RaceName))
            {
             query = query.Where(d => d.Race == RaceName);
            }*/
               query = query.Where(d => d.Id == SubRaceID);
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