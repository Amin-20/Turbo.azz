using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class EFStatusRepository : IStatusRepository
    {
        TurboAzContext _context =new TurboAzContext();
        public void AddData(Status data)
        {
            _context.Statuses.Add(data);
            _context.SaveChanges();
        }

        public void DeleteData(Status data)
        {
            throw new NotImplementedException();
        }

        public ICollection<Status> GetAll()
        {
            return _context.Statuses.ToList();
        }

        public Status GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Status data)
        {
            throw new NotImplementedException();
        }
    }
}
