using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Entities
{
    public class Location : BaseEntity
    {
        public string LocationName { get; set; }
        public virtual List<Event> Events { get; set; }
    }
}
