using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestminsterConfession.v1.DB.Entities;

namespace WestminsterConfession.v1.DB.Mappings
{
    public class BibleVerseMapping:
        EntityTypeConfiguration<BibleVerse>
    {
        public BibleVerseMapping()
        {
            ToTable("BibleVerses")
                .HasKey(b => b.Id);

            HasMany(s => s.Sections)
                .WithMany(b => b.BibleVerses)
                .Map(bs =>
                {
                    bs.MapLeftKey("BibleVerseId");
                    bs.MapRightKey("SectionId");
                    bs.ToTable("BibleVerseSection");
                    
                });
        }
    }
}
