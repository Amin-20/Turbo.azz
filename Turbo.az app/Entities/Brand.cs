using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class Brand
    {
        public int Id { get; set; } 
        public string BrandName { get; set; }    
        public virtual ICollection<Model> Models { get; set; }
    }
}
