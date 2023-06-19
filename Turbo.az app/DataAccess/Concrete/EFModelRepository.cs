using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class EFModelRepository : IModelRepository
    {
        TurboAzContext _context = new TurboAzContext();
        public void AddData(Model data)
        {
            _context.Models.Add(data);
            _context.SaveChanges();
        }

        public void DeleteData(Model data)
        {
            throw new NotImplementedException();
        }

        public ICollection<Model> GetAll()
        {
            return _context.Models.ToList();
        }

        public Model GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Model data)
        {
            throw new NotImplementedException();
        }
    }
}
