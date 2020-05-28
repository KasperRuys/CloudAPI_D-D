using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using dndAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace dndAPI.Controllers
{
    [Route("api/Race")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        MyDbContext ctx;
        public RaceController(MyDbContext context)
        {
            this.ctx = context;
        }



        //krijgt lege pagina als ik probeer aan te roepen api/race. api/race/1 werkt wel
       /* [HttpGet]
        public List<Race> GetSubracesByRaceID(int RaceID, string RaceName, string SubRaceName, int? page = 0, string sort = "RaceName", int length = 2, string dir = "asc")
        {
            IQueryable<Race> query = ctx.Races;
            var race = ctx.Races
                              .SingleOrDefault(d => d.ID == RaceID);
            if (!string.IsNullOrEmpty(RaceName))
            {
                query = query.Where(d => d.RaceName == RaceName);
            }
            /* if (!string.IsNullOrEmpty(SubRaceName))
            {
             query = query.Where(d => d.SubRaces == SubRaceName);
            }*/
         /*   query = query.Where(d => d.ID == RaceID);
            if (dir == "asc")
            {
                query = query.OrderBy(d => d.RaceName);
            }
            else if (dir == "desc")
            {
                query = query.OrderByDescending(d => d.ID);
            }
            if (page.HasValue)
            {
                query = query.Skip(page.Value * length);
            }
            query = query.Take(length);
            return query.ToList();

        }

        */


        // GET: api/Default
        [HttpGet(Name = "GetAllRaces")]
        
        public IEnumerable<Race> Get()
        {

            return this.ctx.Races.ToList();

        }
        //Hoe zoeken op ID en naam?
        // GET: api/Default/5
        [HttpGet("{id}", Name = "GetRaceByID")]
        
        public IActionResult GetRaceByID(int id)
        {
            Race race = ctx.Races.Find(id);
            if (race == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(race);
            }
        }



       

        // POST: api/Default
        [HttpPost(Name = "AddRace")]
        public IActionResult AddRace([FromBody] Race Race)
        {
            ctx.Races.Add(Race);
            ctx.SaveChanges();
            return Ok(Race);
        }

        // PUT: api/Default/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Race updatedRace)
        {
            var race = ctx.Races.Find(id);
            if (race == null)
            {
                return NotFound();
            }
            else
            {
                race.RaceName = updatedRace.RaceName;
                race.RaceFeatures = updatedRace.RaceFeatures;
                ctx.SaveChanges();
                return Ok(race);
            }
        }


      /*  [HttpPut]
        public IActionResult UpdateRace([FromBody] Race updateRace)
        {
            var race = ctx.Races.Find(updateRace.ID);
            if (race == null)
            {
                return NotFound();
            }
            else
            {
                race.ID = updateRace.ID;
                race.RaceName = updateRace.RaceName;
                race.RaceFeatures = updateRace.RaceFeatures;

                ctx.SaveChanges();
                return Ok(race);
            }
        }*/

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult DeleteRace(int id)
        {
            Race race = ctx.Races.Find(id);
            SubRace subrace = ctx.SubRaces.Find(id);
            if (race != null) {
                ctx.Races.Remove(ctx.Races.Find(id));
                ctx.SaveChanges();
                return Ok("Deleted race with ID "+ id);
            }
            return NotFound("No race found with ID: " + id);
        }
        //race 10 gaat niet? delete van subraces ook

    }
}