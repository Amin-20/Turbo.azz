using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class BodyType
    {
        public int Id { get; set; }
        public string BodyTypeName { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

        public override string ToString()
        {
            return BodyTypeName;
        }
    }
}
