using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestminsterConfession.v1.DB.Entities
{
  public class Charper
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public int NumberPosition { get; set; }
    public string RomanNumber { get; set; }
    public string Resume { get; set; }
    public virtual ICollection<Section> Sections { get; set; }

  }

}
