using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class EFCityRepository : ICityRepository
    {
        TurboAzContext _context = new TurboAzContext();
        public void AddData(City data)
        {
            _context.Cities.Add(data);
            _context.SaveChanges();
        }

        public void DeleteData(City data)
        {
            throw new NotImplementedException();
        }

        public ICollection<City> GetAll()
        {
            return _context.Cities.ToList();
        }

        public City GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(City data)
        {
            throw new NotImplementedException();
        }
    }
}
