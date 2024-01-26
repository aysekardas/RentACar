using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class RentACarContext : DbContext
    {

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Fuel>Fuels { get; set; }

        public DbSet<Transmission> Transmissions { get; set; }

        public DbSet<Model>Models  { get; set; }

        public DbSet<Car>Cars { get; set; }

        public RentACarContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }


    }
}
