using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestminsterConfession.v1.DB.Entities;

namespace WestminsterConfession.v1.DB.Mappings
{
    public class SectionMapping:
        EntityTypeConfiguration<Section>
    {
        public SectionMapping()
        {
            ToTable("Sections")
                .HasKey(s => s.Id);

            HasRequired(c => c.Charper)
                .WithMany(c => c.Sections)
                .HasForeignKey(c => c.CharperId);
        }
    }
}
