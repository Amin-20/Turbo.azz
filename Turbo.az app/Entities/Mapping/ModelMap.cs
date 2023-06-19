using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class ModelMap : EntityTypeConfiguration<Model>
    {
        public ModelMap()
        {
            this.HasKey(x => x.Id);

            this.Property(m => m.ModelName)
              .IsRequired()
              .HasMaxLength(30)
              .IsUnicode(true);

            this.HasMany(m=>m.Cars)
               .WithOptional()
               .HasForeignKey(c => c.ModelId)
               .WillCascadeOnDelete(true);

            this.Property(m => m.BrandId).HasColumnName("BrandId");
        }
    }
}
