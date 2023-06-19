using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class Status
    {
        public int Id { get; set; }
        public bool IsNew { get; set; } = false;
        public virtual ICollection<Car> Cars { get; set; }
    }
}
