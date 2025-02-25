using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domaine;
using AM.ApplicationCore.Domaines;
using Microsoft.EntityFrameworkCore;

namespace AM.infrastructure
{
    public class AMContext : DbContext
    {
        //1. Dbset for each entity
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        //2. Configuration of the connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; 
                Initial Catalog=MA_4arctic4;Integrated Security=true"); 
            base.OnConfiguring(optionsBuilder);
        }


    }
}
