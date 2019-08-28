using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veteria58.Web.Data.Entities;

namespace Veteria58.Web.Data
{
    public class DataContext: DbContext

    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {


        }

      
        public DbSet<Agenda> Agendas  { get; set; }
        public DbSet<History> Histories { get; set; }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
    }
}
