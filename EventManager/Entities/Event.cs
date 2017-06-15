using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Entities
{
    public class Event : BaseEntity
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public virtual Location Location { get; set; }
    }
}
