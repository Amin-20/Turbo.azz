using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class Color
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

        public override string ToString()
        {
            return ColorName;
        }
    }
}
