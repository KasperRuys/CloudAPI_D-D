using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dndAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace dndAPI.Model
{
    public class DBInit
    {
           public static void Initialize(dndAPI.MyDbContext context)
           {

            context.Database.EnsureCreated();

           if (!context.Races.Any())
            {
                Race rc0 = new Race()
                {
                    RaceName = "Aasimar",
                    RaceFeatures = "Darkvision. +2 Charisma",
                    SubRaces = new List<SubRace>(),
                 //   ClassRaces = new List<ClassRace>()
                };
                Race rc1 = new Race()
                      {
                          RaceName = "Dwarf",
                        RaceFeatures = "DarkVision. +2 Strength",
                    SubRaces = new List<SubRace>(),
                  //  ClassRaces = new List<ClassRace>()
                };
                      Race rc2 = new Race()
                      {
                          RaceName = "Elf",
                          RaceFeatures = "DarkVision. +2 Dexterity",
                          SubRaces = new List<SubRace>(),
                      //    ClassRaces = new List<ClassRace>()
                      };
                      Race rc3 = new Race()
                      {
                          RaceName = "Genasi",
                          RaceFeatures = "+2 Constitution",
                          SubRaces = new List<SubRace>(),
                      //    ClassRaces = new List<ClassRace>()
                      };
                      Race rc4 = new Race()
                      {
                          RaceName = "Gnome",
                          RaceFeatures = "Darkvision. +2 Intellect",
                          SubRaces = new List<SubRace>(),
                    //      ClassRaces = new List<ClassRace>()
                      };
                      Race rc5 = new Race()
                      {
                          RaceName = "Goblin",
                          RaceFeatures = "Darkvision. +2 Dexterity. +1 Constitution",
                          SubRaces = new List<SubRace>(),
                       //   ClassRaces = new List<ClassRace>()
                      };
                      Race rc6 = new Race()
                      {
                          RaceName = "Halfling",
                          RaceFeatures = "+2 Dexterity",
                          SubRaces = new List<SubRace>(),
                     //     ClassRaces = new List<ClassRace>()
                      };
                      Race rc7 = new Race()
                      {
                          RaceName = "Half-Orc",
                          RaceFeatures = "Darkvision. +2 Strength. +1 Constitution",
                          SubRaces = new List<SubRace>(),
                       //   ClassRaces = new List<ClassRace>()
                      };
                      Race rc8 = new Race()
                      {
                          RaceName = "Human",
                          RaceFeatures = "+1 ALL",
                          SubRaces = new List<SubRace>(),
                      //    ClassRaces = new List<ClassRace>()
                      };
                      Race rc9 = new Race()
                      {
                          RaceName = "Tiefling",
                          RaceFeatures = "Darkvision. +2 Charisma",
                          SubRaces = new List<SubRace>(),
                       //   ClassRaces = new List<ClassRace>()
                      };
    

                if (!context.SubRaces.Any())
                {

                    var sr1 = new SubRace()
                    {
                        Race = rc0,
                        SubRaceName = "Protector",
                        SubraceFeatures = "+1 Wisdom",
                        Link = "https://localhost:44370/api/Race/1"

                    };
                    var sr2 = new SubRace()
                    {
                        Race = rc0,
                        SubRaceName = "Scourge",
                        SubraceFeatures = "+1 Constitution",
                        Link = "https://localhost:44370/api/Race/1"
                    };
                    var sr3 = new SubRace()
                    {
                        Race =rc0,
                        SubRaceName = "Fallen",
                        SubraceFeatures = "+1 Strength",
                        Link = "https://localhost:44370/api/Race/1"
                    };
                    var sr4 = new SubRace()
                    {
                        Race = rc1,
                        SubRaceName = "Hill",
                        SubraceFeatures = "+1 Wisdom",
                        Link = "https://localhost:44370/api/Race/2"
                    };
                    var sr5 = new SubRace()
                    {
                        Race = rc1,
                        SubRaceName = "Mountain",
                        SubraceFeatures = "+2 Strength",
                        Link = "https://localhost:44370/api/Race/2"
                    };
                    var sr6 = new SubRace()
                    {
                        Race = rc1,
                        SubRaceName = "Duergar",
                        SubraceFeatures = "Superior Darkvision. +1 Strength",
                        Link = "https://localhost:44370/api/Race/2"
                    };
                    var sr7 = new SubRace()
                    {
                        Race = rc2,
                        SubRaceName = "Drow",
                        SubraceFeatures = "Superior Darkvision. +1 Charisma",
                        Link = "https://localhost:44370/api/Race/3"
                    };
                    var sr8 = new SubRace()
                    {
                        Race = rc2,
                        SubRaceName = "Eladrin",
                        SubraceFeatures = "+1 Intellect",
                        Link = "https://localhost:44370/api/Race/3"
                    };
                    var sr9 = new SubRace()
                    {
                        Race = rc2,
                        SubRaceName = "High",
                        SubraceFeatures = "+1 Intellect",
                        Link = "https://localhost:44370/api/Race/3"
                    }; var sr10 = new SubRace()
                    {
                        Race = rc2,
                        SubRaceName = "Wood",
                        SubraceFeatures = "+5ft Speed. +1 Wisdom",
                        Link = "https://localhost:44370/api/Race/3"
                    };
                    var sr11 = new SubRace()
                    {
                        Race = rc2,
                        SubRaceName = "Tajuru",
                        SubraceFeatures = "+1 Charisma. +2 Wisdom. -2 Dexterity",
                        Link = "https://localhost:44370/api/Race/3"
                    };
                    var sr12 = new SubRace()
                    {
                        Race = rc2,
                        SubRaceName = "Joraga",
                        SubraceFeatures = "+5ft Speed. -1 Dexterity. +2Wisdom",
                        Link = "https://localhost:44370/api/Race/3"
                    }; var sr13 = new SubRace()
                    {
                        Race = rc2,
                        SubRaceName = "Mul Daya",
                        SubraceFeatures = "Superior Darkvision. +1 Strength. +2 Wisdom. -2 Dexterity",
                        Link = "https://localhost:44370/api/Race/3"
                    };
                    var sr14 = new SubRace()
                    {
                        Race = rc3,
                        SubRaceName = "Air",
                        SubraceFeatures = "+1 Dexterity",
                        Link = "https://localhost:44370/api/Race/4"
                    };
                    var sr15 = new SubRace()
                    {
                        Race = rc3,
                        SubRaceName = "Earth",
                        SubraceFeatures = "+1 Strength",
                        Link = "https://localhost:44370/api/Race/4"
                    }; var sr16 = new SubRace()
                    {
                        Race = rc3,
                        SubRaceName = "Fire",
                        SubraceFeatures = "+1 Intellect",
                        Link = "https://localhost:44370/api/Race/4"
                    };
                    var sr17 = new SubRace()
                    {
                        Race = rc3,
                        SubRaceName = "Water",
                        SubraceFeatures = "+1 Wisdom",
                        Link = "https://localhost:44370/api/Race/4"
                    };
                    var sr18 = new SubRace()
                    {
                        Race = rc4,
                        SubRaceName = "Deep",
                        SubraceFeatures = "+1 Dexterity",
                        Link = "https://localhost:44370/api/Race/5"
                    };
                    var sr19 = new SubRace()
                    {
                        Race = rc4,
                        SubRaceName = "Forest",
                        SubraceFeatures = "+1 Dexterity",
                        Link = "https://localhost:44370/api/Race/5"
                    }; var sr20 = new SubRace()
                    {
                        Race = rc4,
                        SubRaceName = "Rock",
                        SubraceFeatures = "+1 Constitution",
                        Link = "https://localhost:44370/api/Race/5"
                    }; var sr21 = new SubRace()
                    {
                        Race =rc5,
                        SubRaceName = "Grotag",
                        SubraceFeatures = "Animal Handling Skill",
                        Link = "https://localhost:44370/api/Race/6"
                    }; var sr22 = new SubRace()
                    {
                        Race = rc5,
                        SubRaceName = "Lavastep",
                        SubraceFeatures = "Advantage on Stealth",
                        Link = "https://localhost:44370/api/Race/6"
                    }; var sr23 = new SubRace()
                    {
                        Race = rc5,
                        SubRaceName = "Tuktuk",
                        SubraceFeatures = "Thieves' Tools proficiency",
                        Link = "https://localhost:44370/api/Race/6"
                    }; var sr24 = new SubRace()
                    {
                        Race = rc6,
                        SubRaceName = "Lightfoot",
                        SubraceFeatures = "+1 Charisma",
                        Link = "https://localhost:44370/api/Race/7"
                    };
                    var sr25 = new SubRace()
                    {
                        Race = rc6,
                        SubRaceName = "Stout",
                        SubraceFeatures = "+1 Constitution",
                        Link = "https://localhost:44370/api/Race/7"
                    };
                    var sr26 = new SubRace()
                    {
                        Race = rc6,
                        SubRaceName = "Ghostwise",
                        SubraceFeatures = "+1 Wisdom",
                        Link = "https://localhost:44370/api/Race/7"
                    }; var sr27 = new SubRace()
                    {
                        Race = rc9,
                        SubRaceName = "Abyssal",
                        SubraceFeatures = "+1hp/lvl. +1 Constitution",
                        Link = "https://localhost:44370/api/Race/10"
                    }; var sr28 = new SubRace()
                    {
                        Race = rc9,
                        SubRaceName = "Infernal",
                        SubraceFeatures = "+1 Intellect",
                        Link = "https://localhost:44370/api/Race/10"
                    }; var sr29 = new SubRace()
                    {
                        Race = rc9,
                        SubRaceName = "Feral",
                        SubraceFeatures = "+2 Dexterity. -2 Wisdom",
                        Link = "https://localhost:44370/api/Race/10"
                    };


                    if (!context.Classes.Any())
                    {
                       /* var cl1 = new Class()
                        {
                            ClassName = "Barbarian",
                            ClassRequirements = "13 Strength",
                            HitDie = 12,
                            ClassRaces = new List<ClassRace>() 
                        };
                        
                        var cl2 = new Class()
                        {
                            ClassName = "Bard",
                            ClassRequirements = "13 Charisma",
                            HitDie = 8,
                            ClassRaces = new List<ClassRace>()

                            //Races = 
                        };
                        
                        var cl3 = new Class()
                        {
                            ClassName = "Cleric",
                            ClassRequirements = "13 Wisdom",
                            HitDie = 8,
                            ClassRaces = new List<ClassRace>()
                            //Races = 
                        };
                        var cl4 = new Class()
                        {
                            ClassName = "Druid",
                            ClassRequirements = "No metal armour",
                            HitDie = 8,
                            ClassRaces = new List<ClassRace>()
                            //Races = 
                        };
                        var cl5 = new Class()
                        {
                            ClassName = "Fighter",
                            ClassRequirements = "13 Strength OR 13 Dexterity",
                            HitDie = 10,
                            ClassRaces = new List<ClassRace>()
                            //Races = 
                        };
                        var cl6 = new Class()
                        {
                            ClassName = "Monk",
                            ClassRequirements = "13 Wisdom",
                            HitDie = 8,
                            ClassRaces = new List<ClassRace>()
                            //Races = 
                        };
                        var cl7 = new Class()
                        {
                            ClassName = "Paladin",
                            ClassRequirements = "13 Strength AND 13 Charisma",
                            HitDie = 10,
                            ClassRaces = new List<ClassRace>()
                            //Races = 
                        };
                        var cl8 = new Class()
                        {
                            ClassName = "Ranger",
                            ClassRequirements = "13 Dexterity",
                            HitDie = 10,
                            ClassRaces = new List<ClassRace>()
                            //Races = 
                        };
                        var cl9 = new Class()
                        {
                            ClassName = "Rogue",
                            ClassRequirements = "13 Dexterity",
                            HitDie = 8,
                            ClassRaces = new List<ClassRace>()
                            //Races = 
                        };
                        var cl10 = new Class()
                        {
                            ClassName = "Sorcerer",
                            ClassRequirements = "13 Charisma",
                            HitDie = 6,
                            ClassRaces = new List<ClassRace>()
                            //Races = 
                        };
                        var cl11 = new Class()
                        {
                            ClassName = "Warlock",
                            ClassRequirements = "13 Charisma",
                            HitDie = 8,
                            ClassRaces = new List<ClassRace>()
                            //Races = 
                        };
                        var cl12 = new Class()
                        {
                            ClassName = "Wizard",
                            ClassRequirements = "13 Intellect",
                            HitDie = 6,
                            ClassRaces = new List<ClassRace>()
                            //Races = 
                        };


                      /*  var cr = new ClassRace
                        {
                            Class = cl3,
                            Race = rc1,
                        };
                        rc1.ClassRaces.Add(cr);
                        cl3.ClassRaces.Add(cr);
                        context.ClassRaces.Add(cr);*/
                      /*  var cr3 = new ClassRace
                        {
                            Class = cl2,
                            Race = rc1,
                        };
                        rc1.ClassRaces.Add(cr3);
                        cl2.ClassRaces.Add(cr3);
                        context.ClassRaces.Add(cr3);*/


/*
                        context.Classes.Add(cl1);
                        context.Classes.Add(cl2);
                        context.Classes.Add(cl3);
                        context.Classes.Add(cl4);
                        context.Classes.Add(cl5);
                        context.Classes.Add(cl6);
                        context.Classes.Add(cl7);
                        context.Classes.Add(cl8);
                        context.Classes.Add(cl9);
                        context.Classes.Add(cl10);
                        context.Classes.Add(cl11);
                        context.Classes.Add(cl12); */
                        // context.SaveChanges();

                    }
                    //context.Races.Find(1).SubRaces.Add(sr1);
                    rc0.SubRaces.Add(sr1);
                    rc0.SubRaces.Add(sr2);
                    rc0.SubRaces.Add(sr3);
                    
                    context.Races.Add(rc0);
                    rc1.SubRaces.Add(sr4);
                    rc1.SubRaces.Add(sr5);
                    rc1.SubRaces.Add(sr6);
                    context.Races.Add(rc1);
                    rc2.SubRaces.Add(sr7);
                    rc2.SubRaces.Add(sr8);
                    rc2.SubRaces.Add(sr9);
                    rc2.SubRaces.Add(sr10);
                    rc2.SubRaces.Add(sr11);
                    rc2.SubRaces.Add(sr12);
                    rc2.SubRaces.Add(sr13);
                    context.Races.Add(rc2);
                    rc3.SubRaces.Add(sr14);
                    rc3.SubRaces.Add(sr15);
                    rc3.SubRaces.Add(sr16);
                    rc3.SubRaces.Add(sr17);
                    context.Races.Add(rc3);
                    rc4.SubRaces.Add(sr18);
                    rc4.SubRaces.Add(sr19);
                    rc4.SubRaces.Add(sr20);
                    context.Races.Add(rc4);
                    rc5.SubRaces.Add(sr21);
                    rc5.SubRaces.Add(sr22);
                    rc5.SubRaces.Add(sr23);
                    context.Races.Add(rc5);
                    context.Races.Add(rc6);
                    rc6.SubRaces.Add(sr24);
                    rc6.SubRaces.Add(sr25);
                    rc6.SubRaces.Add(sr26);
                    context.Races.Add(rc7);
                    context.Races.Add(rc8);
                    rc9.SubRaces.Add(sr27);
                    rc9.SubRaces.Add(sr28);
                    rc9.SubRaces.Add(sr29);
                    context.Races.Add(rc9);
                    context.SaveChanges();
                }
            }

        }



    }


}
