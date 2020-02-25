using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApplication.Entity
{
    public class BusContext : DbContext
    {
        public DbSet<Bus> bus { get; set; }

        public BusContext() : base("ConnectionDB")
        {

        }
    }
}
