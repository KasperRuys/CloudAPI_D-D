using dndAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dndAPI
{
    public class MyDbContext : DbContext
    {




        public DbSet<SubRace> SubRaces { get; set; }

        public DbSet<Race> Races { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassRace> ClassRaces { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options)
          : base(options)
        {

        }


        //Modelbuilder defines the shape of your entities, the relationships between them and how they map to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Race>().
                HasMany(r => r.SubRaces).
                WithOne(s => s.Race).
                IsRequired();


            modelBuilder.Entity<ClassRace>().
                HasKey(cr => new { cr.RaceID, cr.ClassID });

            modelBuilder.Entity<ClassRace>().
                HasOne(x => x.Race).
                WithMany(x => x.ClassRaces).
                HasForeignKey(x => x.RaceID).
                OnDelete(DeleteBehavior.Restrict).
                IsRequired();

            modelBuilder.Entity<ClassRace>().
                HasOne(x => x.Class).
                WithMany(x => x.ClassRaces).
                HasForeignKey(x => x.ClassID).
                OnDelete(DeleteBehavior.Restrict).
                IsRequired();
        }




    }
}
