using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestminsterConfession.v1.DB.Entities;
using WestminsterConfession.v1.DB.Mappings;

namespace WestminsterConfession.v1.DB
{
    public class CoreDBContext: DbContext
    {
        public CoreDBContext()
            :base("WestminsterDB")
        {
            // add configuraton abot migration strategy
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CoreDBContext, Migrations.Configuration>());
        }   
        
        // list of entites to bind
        public DbSet<Charper> Charpers { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<BibleVerse> BibleVerses { get; set; }


        // setup config mappings 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Core");

            modelBuilder.Configurations.Add(new CharperMapping());
            modelBuilder.Configurations.Add(new SectionMapping());
            modelBuilder.Configurations.Add(new BibleVerseMapping());
        }
    }
}
