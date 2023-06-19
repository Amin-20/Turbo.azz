using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class BrandMap : EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            this.HasKey(x => x.Id);

            this.Property(b => b.BrandName)
                   .IsRequired()
                   .HasMaxLength(30)
                   .IsUnicode(true);

            this.HasMany(b => b.Models)
              .WithOptional()
              .HasForeignKey(m => m.BrandId)
              .WillCascadeOnDelete(true);
        }
    }
}
