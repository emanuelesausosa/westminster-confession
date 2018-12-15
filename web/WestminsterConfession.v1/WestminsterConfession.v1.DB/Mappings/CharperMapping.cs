using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestminsterConfession.v1.DB.Entities;

namespace WestminsterConfession.v1.DB.Mappings
{
    public class CharperMapping: EntityTypeConfiguration<Charper>
    {
        public CharperMapping()
        {
            ToTable("Charpers")
                .HasKey(c => c.Id);
                
        }
    }
}
