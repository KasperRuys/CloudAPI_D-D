using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dndAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dndAPI.Controllers
{
    [Route("API/Classes")]
    [ApiController]
    public class ClassesController : Controller
    {

           MyDbContext ctx;
           public ClassesController(MyDbContext context)
           {
               this.ctx = context;
           }

           // GET: api/Default
           [HttpGet]
           public IEnumerable<Class> Get()
           {

               return this.ctx.Classes.ToList();

           }

           // GET: api/Default/5
           [HttpGet("{id}", Name = "GetClass")]
           public IActionResult Get(int id)
           {
               Class classs = ctx.Classes.Find(id);
               if (classs == null)
               {
                   return NotFound();
               }
               else
               {
                   return Ok(classs);
               }
           }

           // POST: api/Default
           [HttpPost]
           public IActionResult AddClass([FromBody] Class Classs)
           {
               ctx.Classes.Add(Classs);
               ctx.SaveChanges();
               return Ok(Classs);
           }

           // PUT: api/Default/5
           [HttpPut("{id}")]
           public IActionResult Put(int id, [FromBody] Class updatedClass)
           {
               var classs = ctx.Classes.Find(id);
               if (classs == null)
               {
                   return NotFound();
               }
               else
               {
                   classs.ClassName = updatedClass.ClassName;
                   classs.ClassRequirements = updatedClass.ClassRequirements;
                   classs.HitDie = updatedClass.HitDie;
                //   classs.ClassRaces = updatedClass.ClassRaces;
                   ctx.SaveChanges();
                   return Ok(classs);
               }
           }

        /*
             [HttpPut]
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
             }
        */
                // DELETE: api/ApiWithActions/5
                [HttpDelete("{id}")]
                public IActionResult DeleteClass(int id)
                {
                    Class classs = ctx.Classes.Find(id);
                    Race race = ctx.Races.Find(id);
                    if (classs != null)
                    {
                        ctx.Classes.Remove(ctx.Classes.Find(id));
                        ctx.SaveChanges();
                        return Ok("Deleted class with ID " + id);
                    }
                    return NotFound("No class found with ID: " + id);
                }
                //race 10 gaat niet? delete van subraces ook
                
    }


}