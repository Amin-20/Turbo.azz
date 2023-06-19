using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class BodyTypeMap:EntityTypeConfiguration<BodyType>
    {
        public BodyTypeMap()
        {
            this.HasKey(x => x.Id);

            this.Property(b => b.BodyTypeName)
               .IsRequired()
               .HasMaxLength(30)
               .IsUnicode(true);

            this.HasMany(b => b.Cars)
             .WithOptional()
             .HasForeignKey(c => c.BodyTypeId)
             .WillCascadeOnDelete(true);
        }
    }
}
