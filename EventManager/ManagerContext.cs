using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    public class ManagerContext : DbContext
    {
        public ManagerContext() : base("EventManagerDB")
        {

        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
