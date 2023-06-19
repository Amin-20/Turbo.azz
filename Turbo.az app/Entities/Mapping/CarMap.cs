using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class CarMap:EntityTypeConfiguration<Car>    
    {
        public CarMap()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.ColorId).HasColumnName("ColorId");
            this.Property(c => c.ModelId).HasColumnName("ModelId");
            this.Property(c => c.BodyTypeId).HasColumnName("BodyTypeId");
            this.Property(c => c.CityId).HasColumnName("CityId");

            this.Property(c => c.Kilometer)
                .IsRequired();

            this.Property(c => c.Price)
                .IsRequired();

            this.Property(c => c.IsNew)
                .IsRequired();

            this.Property(c => c.Engine)
                .IsRequired();

        }
    }
}
