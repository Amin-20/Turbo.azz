using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            this.HasKey(x => x.Id);

            this.ToTable("Cities");

            this.Property(c => c.CityName)
               .IsRequired()
               .HasMaxLength(30)
               .IsUnicode(true);

            this.HasMany(c => c.Cars)
             .WithOptional()
             .HasForeignKey(c => c.CityId)
             .WillCascadeOnDelete(true);

        }
    }
}
