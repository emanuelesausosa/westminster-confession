using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestminsterConfession.v1.DB.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string RomanNumber { get; set; }
        public string Text { get; set; }
        public int CharperId { get; set; }
        public virtual Charper Charper { get; set; }

        public virtual ICollection<BibleVerse> BibleVerses { get; set; }
    }
}
