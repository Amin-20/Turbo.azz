using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.Entities.Mapping
{
    public class Car
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public bool IsNew { get; set; }
        public int BodyTypeId { get; set; }
        public int CityId { get; set; } 
        public float Kilometer { get; set; }
        public decimal Price { get; set; }
        public DateTime ProdYear { get; set; }
        public string ImagePath { get; set; }
        public int FuelTypeId { get; set; }
        public string Engine { get; set; }


        public virtual Color Color { get; set; }
        public virtual Model Model { get; set; }
        public virtual BodyType BodyType { get; set; } 
        public virtual City City { get; set; }
        public virtual FuelType FuelType { get; set; }      
    }
}