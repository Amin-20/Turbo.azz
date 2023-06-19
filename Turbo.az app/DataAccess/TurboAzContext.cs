using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess
{
    public class TurboAzContext:DbContext
    {
        public TurboAzContext()
        :base("TurboAzDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new ModelMap());
            modelBuilder.Configurations.Add(new BodyTypeMap());
            modelBuilder.Configurations.Add(new CarMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new ColorMap());
            modelBuilder.Configurations.Add(new StatusMap());
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }

    }
}
