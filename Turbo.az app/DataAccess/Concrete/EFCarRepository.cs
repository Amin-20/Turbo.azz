using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class EFCarRepository : ICarRepository
    {
        TurboAzContext _context = new TurboAzContext();
        public void AddData(Car data)
        {
            _context.Cars.Add(data);
            _context.SaveChanges();
        }

        public void DeleteData(Car data)
        {
            throw new NotImplementedException();
        }

        public ICollection<Car> GetAll()
        {
            return _context.Cars.ToList();
        }

        public Car GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Car data)
        {
            throw new NotImplementedException();
        }
    }
}
