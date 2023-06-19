using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class StatusMap:EntityTypeConfiguration<Status>  
    {
        public StatusMap()
        {
            this.HasKey(x => x.Id);

            this.Property(s => s.IsNew)
                .IsRequired();

            this.HasMany(s => s.Cars)
              .WithOptional()
              .HasForeignKey(c => c.StatusId)
              .WillCascadeOnDelete(true);
        }
    }
}
