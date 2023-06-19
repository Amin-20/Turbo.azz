using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.Entities
{
    public class FuelType
    {
        public int FuelTypeId { get; set; }
        public string FuelName { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
