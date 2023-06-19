using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class ColorMap:EntityTypeConfiguration<Color>    
    {
        public ColorMap()
        {
            this.HasKey(x => x.Id);

            this.Property(c => c.ColorName)
              .IsRequired()
              .HasMaxLength(30)
              .IsUnicode(true);

            this.HasMany(c => c.Cars)
            .WithOptional()
            .HasForeignKey(c => c.ColorId)
            .WillCascadeOnDelete(true);
        }
    }
}
