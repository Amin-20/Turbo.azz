using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class Model
    {
        public int Id{ get; set; }
        public string ModelName { get; set; }
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

        public override string ToString()
        {
            return ModelName;
        }
    }
}
