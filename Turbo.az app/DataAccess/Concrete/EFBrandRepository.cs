using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class EFBrandRepository : IBrandRepository
    {
        TurboAzContext _context=new TurboAzContext();   
        public void AddData(Brand data)
        {
            _context.Brands.Add(data);
            _context.SaveChanges();
        }

        public void DeleteData(Brand data)
        {
            throw new NotImplementedException();
        }

        public ICollection<Brand> GetAll()
        {
            return _context.Brands.ToList();
        }

        public Brand GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Brand data)
        {
            throw new NotImplementedException();
        }
    }
}
