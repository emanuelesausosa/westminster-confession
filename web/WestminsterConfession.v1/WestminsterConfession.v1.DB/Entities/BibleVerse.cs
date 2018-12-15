using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestminsterConfession.v1.DB.Entities
{
    public class BibleVerse
    {

        public BibleVerse()
        {
            
        }

        public int Id { get; set; }
        public string Book { get; set; }
        public int BibleCharper { get; set; }
        public int NumberCite { get; set; }
        public string Text { get; set; }
        
        public virtual ICollection<Section> Sections { get; set; }

    }
}
